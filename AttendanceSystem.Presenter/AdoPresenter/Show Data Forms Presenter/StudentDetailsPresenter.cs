using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;

namespace AttendanceSystem.Presenter.AdoPresenter.Show_Data_Forms_Presenter;

public class StudentDetailsPresenter
{
    private readonly IStudentDetailsView studentDetailsView;
    private readonly IUnitOFWork unitOFWork;

    public StudentDetailsPresenter(IStudentDetailsView studentDetailsView,IUnitOFWork unitOFWork)
    {
        this.studentDetailsView = studentDetailsView;
        this.unitOFWork = unitOFWork;
        IRaiseItemChangedEvents();
    }

    private void IRaiseItemChangedEvents()
    {
        studentDetailsView.LoadTermCoursesOfStudent += LoadTermCoursesOfStudent;
        studentDetailsView.GetSSOfTermCourseForSpecificStudent += GetSSOfTermCourseForSpecificStudent;
    }

    private void GetSSOfTermCourseForSpecificStudent(object? sender, EventArgs e)
    {
        try
        {
            var termCourseID = (int)sender!;
            var studentID = studentDetailsView.StudentFullInfoModel.StudentID;
            studentDetailsView.StudentStatusInfoPerTermCourse = unitOFWork.StudentStatusRepository.StudentStatusesInfo_TermCourseAndStudent(studentID, termCourseID);
            studentDetailsView.IsSucess = true;
        }
        catch (Exception ex)
        {
            studentDetailsView.Message = ex.Message;
            studentDetailsView.IsSucess = false;
        }
    }

    private void LoadTermCoursesOfStudent(object? sender, EventArgs e)
    {
        try
        {
            studentDetailsView.TermCoursesDetails = unitOFWork.TermCourseRepository.GetTermCoursesByStudentID(studentDetailsView.StudentFullInfoModel.StudentID);
            studentDetailsView.IsSucess = true;
        }
        catch (Exception ex)
        {
            studentDetailsView.Message = ex.Message;
            studentDetailsView.IsSucess = false;
        }
    }
}
