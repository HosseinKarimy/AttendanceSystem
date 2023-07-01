using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.MainMenuView;

public interface IMainMenu_Login
{
    public UsersModel UserModel { get; set; }
}
