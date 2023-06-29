using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;

namespace AttendanceSystem.Presenter.IPresenter;

public interface IStudentStatusUCView
{
    public StudentStatusModel StudentStatusModel { get; set; }
    public StudentFullInfoModel StudentFullInfoModel { get; set; }

    public event EventHandler ChangePresentStatus;
}
