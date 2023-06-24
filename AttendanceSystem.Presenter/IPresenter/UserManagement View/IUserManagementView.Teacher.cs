using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IUserManagementView
{
    public TeacherModel TeacherModel { get; set; }
    public List<TeacherModel> Teachers { get; set; }

    public event EventHandler LoadTeachers;
    public event EventHandler TeacherSaveEdit;
    public event EventHandler TeacherDelete;
}
