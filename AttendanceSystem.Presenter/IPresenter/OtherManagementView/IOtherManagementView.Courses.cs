using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<CourseModel> Courses { get; set; }
    public CourseModel CourseModel { get; set; }

    public event EventHandler LoadCourses;
    public event EventHandler DeleteCourse;
    public event EventHandler SaveCreateCourse;
}
