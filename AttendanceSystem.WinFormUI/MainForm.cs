using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;

namespace AttendanceSystem.WinFormUI;

public partial class MainForm : Form, IMainMenuView
{

    public MainForm()
    {
        InitializeComponent();
        //LoadLoginForm();
        UserManagmentButton.Visible = true;
        ClassManagementButton.Visible = true;
        AttendanceListButton.Visible = true;
        DisplayDataButton.Visible = true;
    }

    public UsersModel UserModel { get; set; }

    private void LoadLoginForm()
    {
        var newForm = FormContainer.LoginView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    private void DisplayDataButton_Click(object sender, EventArgs e)
    {
        var newForm = FormContainer.OverviewFormView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    private void AttendanceListButton_Click(object sender, EventArgs e)
    {
        var newForm = FormContainer.AttendanceListView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    private void UserManagmentButton_Click(object sender, EventArgs e)
    {
        var newForm = FormContainer.UserManagementView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    private void ClassManagementButton_Click(object sender, EventArgs e)
    {
        var newForm = FormContainer.ClassManagementView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    private void OtherManagementButton_Click(object sender, EventArgs e)
    {
        var newForm = FormContainer.OtherManagementView as Form;
        initForm(newForm!);
        SetContainerControl(newForm!);
        newForm!.Show();
    }

    //Methods
    private void SetContainerControl(Form form)
    {
        ContainerPanel.Controls.Clear();
        ContainerPanel.Controls.Add(form);
    }

    private void initForm(Form form)
    {
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
    }

    //public void CompleteLoginProgress(UsersModel usermodel,ILoginView loginView)
    //{
    //    switch (usermodel.Role)
    //    {
    //        case Role.Admin:
    //            MessageBox.Show($"Welcome Admin {usermodel.AdminModel?.FirstName} {usermodel.AdminModel?.LastName}");
    //            InitAdminUser(usermodel.AdminModel!);
    //            break;
    //        case Role.Teacher:
    //            MessageBox.Show($"Welcome Teacher {usermodel.TeacherModel?.FirstName} {usermodel.TeacherModel?.LastName}");
    //            InitTeacherUser(usermodel.TeacherModel!);
    //            break;
    //        case Role.Student:
    //            MessageBox.Show($"Welcome Student {usermodel.StudentModel?.FirstName} {usermodel.StudentModel?.LastName}");
    //            InitStudentModel(usermodel.StudentModel!);
    //            break;
    //    }
    //    UserModel=usermodel;
    //    (loginView as Form)!.Dispose();
    //}

    private void InitStudentModel(StudentModel studentModel)
    {
        NameMenuItem.Text = "Student";
        // RoleTextBox.Text = studentModel.FullName;
    }

    private void InitTeacherUser(TeacherModel teacherModel)
    {
        NameMenuItem.Text = "Teacher";
        //RoleTextBox.Text = teacherModel.FullName;
        AttendanceListButton.Visible = true;
    }

    private void InitAdminUser(AdminModel adminModel)
    {
        NameMenuItem.Text = "Admin";
        //RoleTextBox.Text = adminModel.FullName;
        UserManagmentButton.Visible = true;
        ClassManagementButton.Visible = true;
        AttendanceListButton.Visible = true;
        DisplayDataButton.Visible = true;
    }

    //private void toolStripTextBox2_Click(object sender, EventArgs e)
    //{
    //    (classManagementView as Form)?.Dispose();
    //    (attendanceListView as Form)?.Dispose();
    //    (searchView as Form)?.Dispose();
    //    (userManagementView as Form)?.Dispose();

    //    NameMenuItem.Text = "LOGIN";
    //    RoleTextBox.Text = String.Empty;
    //    UserManagmentButton.Visible = false;
    //    ClassManagementButton.Visible = false;
    //    AttendanceListButton.Visible = false;
    //    DisplayDataButton.Visible = false;


    //    LoadLoginForm();
    //}


    UsersModel IMainMenu_Login.UserModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}