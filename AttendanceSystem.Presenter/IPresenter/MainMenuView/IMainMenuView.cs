using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

namespace AttendanceSystem.Presenter.IPresenter.MainMenuView;

public interface IMainMenuView : IMainMenu_Login
{
    IClassManagementView ClassManagementView { get; }
    IAttendanceListView AttendanceListView { get; }
    ISearchView SearchView { get; }
    IUserManagementView UserManagementView { get; }

    IUnitOFWork UnitOFWork { get; }
}
