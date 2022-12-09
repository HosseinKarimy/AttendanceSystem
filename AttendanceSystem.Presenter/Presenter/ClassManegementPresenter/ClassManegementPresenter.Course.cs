using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.ModelValidator;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Models;

namespace AttendanceSystem.Presenter.Presenter.ClassManegementPresenter;

public partial class ClassManegementPresenter
{
    private void RaiseCourseEvents()
    {
        view.RemoveSection += View_RemoveSection;
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

                //load sections from db
                var sections = new List<SectionModel>();
                foreach (SectionModel section in view.CourseModel.Sections)
                {
                    sections.Add(unitOFWork.SectionRepository.FirstOrDefault(u => u.Id == section.Id));
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

    private void View_RemoveSection(object? sender, EventArgs e)
    {
        try
        {
            unitOFWork.SectionRepository.Delete(view.SectionModel);
            unitOFWork.Save();
            view.IsSucess = true;
            view.Message = "Deleted Successfully";
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
