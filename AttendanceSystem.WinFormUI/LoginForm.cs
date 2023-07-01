using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Presenter.IInteraction;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.WinFormUI;

public partial class LoginForm : Form, ILoginView
{
    private readonly ILoginFormMainMenuIntraction interactionWithMain;

    public LoginForm(ILoginFormMainMenuIntraction intractionWithMain)
    {
        InitializeComponent();
        this.interactionWithMain = intractionWithMain;
    }

    public UsersModel UserModel { get; set; }
    public bool IsSucess { get; set; }
    public string Message { get; set; }

    public event EventHandler Login;

    private void LoginButton_Click(object sender, EventArgs e)
    {
        //UserModel = new UsersModel()
        //{
        //    Username = UsernameTextBox.Text,
        //    Password = PasswordTextBox.Text
        //};
        //Login?.Invoke(sender, e);
        //if (IsSucess)
        //{
        //    interactionWithMain.CompleteLoginProgress(UserModel, this);
        //}
        //else
        //    MessageBox.Show(Message);
    }
}
