using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.Presenter.IInteraction;

public interface ILoginFormMainMenuIntraction
{
    void CompleteLoginProgress(UsersModel Usermodel, ILoginView loginView);
}
