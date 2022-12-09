using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.ModelValidator;
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
