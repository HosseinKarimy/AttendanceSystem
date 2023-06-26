using AttendanceSystem.Models.Enums;

namespace AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter;

public partial class OtherManagementPresenter
{
    private void RaiseCourseEvents()
    {
        otherManagementView.SaveCreateCourse += SaveCreateCourse;
        otherManagementView.DeleteCourse += DeleteCourse;
        otherManagementView.LoadCourses += LoadCourses;
    }

    private void LoadCourses(object? sender, EventArgs e)
    {
        try
        {
            otherManagementView.Courses = unitOFWork.CourseRepository.GetAll();
            otherManagementView.IsSucess = true;
        }
        catch (Exception ex)
        {
            otherManagementView.Message = ex.Message;
            otherManagementView.IsSucess = false;
        }
    }

    private void DeleteCourse(object? sender, EventArgs e)
    {
        try
        {
            unitOFWork.CourseRepository.Delete(otherManagementView.CourseModel);
            otherManagementView.Message = "Course Deleted From DataBase...";
            otherManagementView.IsSucess = true;
        }
        catch (Exception ex)
        {
            otherManagementView.Message = ex.Message;
            otherManagementView.IsSucess = false;
        }
    }

    private void SaveCreateCourse(object? sender, EventArgs e)
    {
        switch (otherManagementView.ActionType)
        {
            case ActionType.Create:
                try
                {
                    unitOFWork.CourseRepository.Add(otherManagementView.CourseModel);
                    otherManagementView.Message = "Course Added To DataBase...";
                    otherManagementView.IsSucess = true;
                }
                catch (Exception ex)
                {
                    otherManagementView.Message = ex.Message;
                    otherManagementView.IsSucess = false;
                }
                break;
            case ActionType.Update:
                try
                {
                    unitOFWork.CourseRepository.Update(otherManagementView.CourseModel);
                    otherManagementView.Message = "Course Updated From DataBase...";
                    otherManagementView.IsSucess = true;
                }
                catch (Exception ex)
                {
                    otherManagementView.Message = ex.Message;
                    otherManagementView.IsSucess = false;
                }
                break;
        }
    }
}
