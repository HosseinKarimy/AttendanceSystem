using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.Presenter.Presenter.MainMenuPresenter;

public class LoginPresenter
{
    private readonly ILoginView view;
    private readonly IUnitOFWork unitOFWork;

    public LoginPresenter(ILoginView view, IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;
        view.Login += View_Login;
    }

    private void View_Login(object? sender, EventArgs e)
    {
        try
        {
            //UsersModel userModel = unitOFWork.UsersRepository.FirstOrDefault(u => u.Username == view.UserModel.Username , "StudentModel,TeacherModel,AdminModel");
            //if (userModel is null)
            //{
            //    view.IsSucess = false;
            //    view.Message = "The username or password is incorrect";
            //}
            //else
            //{
            //    view.IsSucess = true;
            //    view.UserModel = userModel;
            //}
        }
        catch (Exception ex)
        {
            view.IsSucess = false;
            view.Message = ex.Message;
        }
    }
}
