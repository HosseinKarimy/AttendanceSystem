using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Presenter.IIntraction;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.WinFormUI;

public partial class LoginForm : Form, ILoginView
{
    private readonly LoginFormMainMenuIntraction intractionWithMain;

    public LoginForm(LoginFormMainMenuIntraction intractionWithMain)
    {
        InitializeComponent();
        this.intractionWithMain = intractionWithMain;
    }

    public UserModel UserModel { get; set; }
    public bool IsSucess { get; set; }
    public string Message { get; set; }

    public event EventHandler Login;

    private void LoginButton_Click(object sender, EventArgs e)
    {
        UserModel = new UserModel()
        {
            Username = UsernameTextBox.Text,
            Password = PasswordTextBox.Text
        };
        Login?.Invoke(sender, e);
        if (IsSucess)
        {
            intractionWithMain.CompleteLoginProgress(UserModel, this);
        }
        else
            MessageBox.Show(Message);
    }
}
