using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter.Common;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface IStudentDetailsView : IResultFeedback
{
    public StudentFullInfoModel StudentFullInfoModel { get; set; }
    public List<TermCourseDetailsModel> TermCoursesDetails { get; set; }
    public List<StudentStatusInfoPerTermCourse> StudentStatusInfoPerTermCourse { get; set; }

    public event EventHandler LoadTermCoursesOfStudent;
    public event EventHandler GetSSOfTermCourseForSpecificStudent;
}
