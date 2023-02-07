using AttendanceSystem.Presenter.IPresenter.Common;

namespace AttendanceSystem.Presenter.IPresenter.MainMenuView;

public interface ILoginView : IMainMenu_Login , IResultFeedback
{
    public event EventHandler Login;
}
