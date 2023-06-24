using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Models.EfCore_Sqllite.ModelValidator;
using AttendanceSystem.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AttendanceSystem.Presenter.Presenter.ClassManegementPresenter;

public partial class ClassManegementPresenter
{
    private void RaiseCourseEvents()
    {
        view.LoadTeachers += View_LoadTeachers;
        view.CourseSaveEdit += View_CourseSaveEdit;
    }

    private void View_CourseSaveEdit(object? sender, EventArgs e)
    {
        if (view.ActionType == ActionType.Create)
        {
            try
            {
                ModelValidation.IsValid<CourseModel>(view.CourseModel);

                //load studens from db
                var students = new List<StudentModel>();
                foreach (StudentModel student in view.CourseModel.Students)
                {
                    students.Add(unitOFWork.StudentRepository.FirstOrDefault(u => u.Id == student.Id, "Courses"));
                }
                view.CourseModel.Students = students;

                //load sections 
                var baseSections = new List<SectionModel>();
                int SectionPerWeek = view.CourseModel.Sections.Count;
                DayOfWeek StartDayOfWeek = view.CourseModel.CourseStartDate.DayOfWeek;
                DateOnly FirstDayDate = new DateOnly(view.CourseModel.CourseStartDate.Year, view.CourseModel.CourseStartDate.Month , view.CourseModel.CourseStartDate.Day);
                for (int i = 0; i < SectionPerWeek; i++)
                {
                    int SectionDiff = 0;
                    while (!view.CourseModel.Sections.Any(u => u.Day == StartDayOfWeek))
                    {
                        SectionDiff++;
                        StartDayOfWeek = (DayOfWeek)(((int)StartDayOfWeek + 1) % 7);
                    }
                    SectionModel FirstSection = view.CourseModel.Sections.FirstOrDefault(u => u.Day == StartDayOfWeek)!;
                    FirstSection.ClassDate = FirstDayDate.AddDays(SectionDiff);
                    baseSections.Add(new SectionModel()
                    {
                        ClassDate = FirstSection.ClassDate,
                        ClassDuration = FirstSection.ClassDuration,
                        Day = FirstSection.Day,
                        StartTime = FirstSection.StartTime
                    });
                    FirstDayDate = FirstDayDate.AddDays(SectionDiff);
                    StartDayOfWeek = FirstSection.Day;
                    view.CourseModel.Sections.Remove(FirstSection);
                }

                var sections = new List<SectionModel>();

                int diffDay = 0;
                for (int numberOfCreatedSections = 1; numberOfCreatedSections <= view.CourseModel.NumberOfSections; )
                {
                    foreach (SectionModel section in baseSections)
                    {
                        List<StudentStatusModel> studnetsStatus = view.CourseModel.Students.Select(
                            u => new StudentStatusModel()
                            {
                                StudentId = u.Id,
                                IsPresent = null                            
                            }
                        ).ToList();
                        sections.Add(new()
                        {
                            ClassDate = section.ClassDate.AddDays(diffDay),
                            ClassDuration = section.ClassDuration,
                            Day = section.Day,
                            StartTime = section.StartTime,
                            SectionNumber = numberOfCreatedSections++,
                            StudentsStatus = studnetsStatus                            
                        });
                        if (view.CourseModel.NumberOfSections < numberOfCreatedSections)
                            break;
                    }
                    diffDay += 7;
                }

                view.CourseModel.Sections = sections;

                //try to add course to db
                unitOFWork.CourseRepository.Add(view.CourseModel);
                unitOFWork.Save();
                view.IsSucess = true;
                view.Message = "Added Successfully";
            }
            catch (Exception ex)
            {
                view.IsSucess = false;
                if (ex.InnerException is not null)
                    view.Message = ex.InnerException.Message;
                else
                    view.Message = ex.Message;

            }
            finally
            {
                unitOFWork.ClearTracker();
            }

        }
    }

    private void View_LoadTeachers(object? sender, EventArgs e)
    {
        view.Teachers = unitOFWork.TeacherRepository.GetAll();
    }
}
