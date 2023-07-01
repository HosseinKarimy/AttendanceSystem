using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;

namespace AttendanceSystem.Presenter.Presenter.ClassManagementPresenter;

public partial class ClassManagementPresenter
{
    private void RaiseCourseEvents()
    {
        view.LoadTeachersAndCoursesAndTerms += LoadTeachersAndCoursesAndTerms;
        view.CourseSaveEdit += View_CourseSaveEdit;
    }

    private void LoadTeachersAndCoursesAndTerms(object? sender, EventArgs e)
    {
        try
        {
            view.Teachers = unitOFWork.TeacherRepository.GetAll();
            view.Courses = unitOFWork.CourseRepository.GetAll();
            view.Terms = unitOFWork.TermRepository.GetAll();
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void View_CourseSaveEdit(object? sender, EventArgs e)
    {
        if (view.ActionType == ActionType.Create)
        {
            try
            {
                var termCourseID = unitOFWork.TermCourseRepository.Add(view.TermCourse);

                var termStartDate = unitOFWork.TermRepository.GetByID(view.TermCourse.TermID)!.StartDate;
                var termEndDate = termStartDate.AddMonths(4);
                var tempSectionsOfWeek = view.SectionsPerWeek.ToList();
                var baseSections = new List<SectionModel>();

                while (tempSectionsOfWeek.Count>0)
                {                
                    while (tempSectionsOfWeek.Any(u=>u.Day == termStartDate.DayOfWeek) is false)
                        termStartDate = termStartDate.AddDays(1);
                    var temp = tempSectionsOfWeek.Find(u => u.Day == termStartDate.DayOfWeek);
                    baseSections.Add(new SectionModel(0, 1, temp!.Duration, 
                        new DateTime(termStartDate.Year,termStartDate.Month,termStartDate.Day,
                        temp.StartTime.Hour,temp.StartTime.Minute,temp.StartTime.Second)
                        , termCourseID));
                    tempSectionsOfWeek.Remove(temp);
                }

                int sectionSwitch = 0;
                int sectionNumber = 1;
                do
                {
                    var current = baseSections.ElementAt(sectionSwitch) with { SectionNumber = sectionNumber++ };
                    var sectionID = unitOFWork.SectionRepository.Add(current);
                    foreach (var student in view.Students)
                    {
                        unitOFWork.StudentStatusRepository.Add(new StudentStatusModel(0, null, null, sectionID, student.StudentID));
                    }
                    current = current with { Date = current.Date!.Value.AddDays(7) };
                    baseSections[sectionSwitch] = current;
                    sectionSwitch = sectionSwitch++ % baseSections.Count;
                    termStartDate = (DateTime)baseSections.ElementAt(sectionSwitch).Date!;

                } while (termStartDate < termEndDate);

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

        }
    }
}
