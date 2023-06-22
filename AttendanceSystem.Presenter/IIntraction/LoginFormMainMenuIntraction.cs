using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.Presenter.IIntraction;

public interface LoginFormMainMenuIntraction
{
    void CompleteLoginProgress(UserModel usermodel, ILoginView loginView);
}
