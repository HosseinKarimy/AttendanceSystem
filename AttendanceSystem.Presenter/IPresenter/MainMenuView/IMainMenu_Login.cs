using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.Presenter.IPresenter.MainMenuView;

public interface IMainMenu_Login
{
    public UserModel UserModel { get; set; }
}
