using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IIntraction;
using AttendanceSystem.Presenter.IPresenter;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using AttendanceSystem.Presenter.Presenter.ClassManegementPresenter;
using AttendanceSystem.Presenter.Presenter.MainMenuPresenter;
using AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;
using AttendanceSystem.Presenter.Presenter.UserManagementPresenter;

namespace AttendanceSystem.WinFormUI
{
    public partial class MainForm : Form , IMainMenuView , LoginFormMainMenuIntraction
    {              

        public MainForm()
        {
            InitializeComponent();
            LoadLoginForm();
        }

        public UserModel UserModel { get; set; }

        private void LoadLoginForm()
        {
            var newForm = LoginView as Form;
            initForm(newForm!);
            SetContainerControl(newForm!);
            newForm!.Show();
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            var newForm = SearchView as Form;
            initForm(newForm!);
            SetContainerControl(newForm!);            
            newForm!.Show();
        }        

        private void AttendanceListButton_Click(object sender, EventArgs e)
        {
            var newForm = AttendanceListView as Form;
            initForm(newForm!);
            SetContainerControl(newForm!);
            newForm!.Show();
        }

        private void UserManagmentButton_Click(object sender, EventArgs e)
        {
            var newForm = UserManagementView as Form;
            initForm(newForm!);
            SetContainerControl(newForm!);
            newForm!.Show();
        }

        private void ClassManagementButton_Click(object sender, EventArgs e)
        {
            var newForm = ClassManagementView as Form;
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

        public void CompleteLoginProgress(UserModel usermodel,ILoginView loginView)
        {
            switch (usermodel.Role)
            {
                case Role.Admin:
                    MessageBox.Show($"Welcome Admin {usermodel.AdminModel?.FirstName} {usermodel.AdminModel?.LastName}");
                    InitAdminUser(usermodel.AdminModel!);
                    break;
                case Role.Teacher:
                    MessageBox.Show($"Welcome Teacher {usermodel.TeacherModel?.FirstName} {usermodel.TeacherModel?.LastName}");
                    InitTeacherUser(usermodel.TeacherModel!);
                    break;
                case Role.Student:
                    MessageBox.Show($"Welcome Student {usermodel.StudentModel?.FirstName} {usermodel.StudentModel?.LastName}");
                    InitStudentModel(usermodel.StudentModel!);
                    break;
            }
            UserModel=usermodel;
            (loginView as Form)!.Dispose();
        }

        private void InitStudentModel(StudentModel studentModel)
        {
            NameMenuItem.Text = "Student";
            RoleTextBox.Text = studentModel.FullName;
        }

        private void InitTeacherUser(TeacherModel teacherModel)
        {
            NameMenuItem.Text = "Teacher";
            RoleTextBox.Text = teacherModel.FullName;
            AttendanceListButton.Visible = true;
        }

        private void InitAdminUser(AdminModel adminModel)
        {
            NameMenuItem.Text = "Admin";
            RoleTextBox.Text = adminModel.FullName;
            UserManagmentButton.Visible = true;
            ClassManagementButton.Visible = true;
            AttendanceListButton.Visible = true;
            DisplayDataButton.Visible = true;
        }



        //Dependency injection - singleton pattern

        private IClassManagementView classManagementView;
        public IClassManagementView ClassManagementView
        {
            get
            {
                if (classManagementView is null || (classManagementView as Form)!.IsDisposed)
                {
                    classManagementView = new ClassManagementForm();
                    new ClassManegementPresenter(ClassManagementView, UnitOFWork);
                }
                return classManagementView;
            }
        }

        private IAttendanceListView attendanceListView;
        public IAttendanceListView AttendanceListView
        {
            get
            {
                if (attendanceListView is null || (attendanceListView as Form)!.IsDisposed)
                {
                    attendanceListView = new AttendanceListForm()
                    {
                        CurrentUser = UserModel,
                        Role = UserModel.Role
                    };
                    new AttendanceListPresenter(AttendanceListView, UnitOFWork);
                }
                return attendanceListView;
            }
        }

        private ISearchView searchView;
        public ISearchView SearchView
        {
            get
            {
                if (searchView is null || (searchView as Form)!.IsDisposed)
                {
                    searchView = new SearchForm();
                    new SearchPresenter(SearchView, UnitOFWork);
                }
                return searchView;
            }
        }

        private IUserManagementView userManagementView;
        public IUserManagementView UserManagementView
        {
            get
            {
                if (userManagementView is null || (userManagementView as Form)!.IsDisposed)
                {
                    userManagementView = new UserManagement();
                    new UserManagementPresenter(userManagementView, UnitOFWork);
                }
                return userManagementView;
            }
        }

        private ILoginView loginView;
        public ILoginView LoginView
        {
            get
            {
                if (loginView is null || (loginView as Form)!.IsDisposed)
                {
                    loginView = new LoginForm(this);
                    new LoginPresenter(loginView, UnitOFWork);
                }
                return loginView;
            }
        }

        private IUnitOFWork unitOFWork;
        public IUnitOFWork UnitOFWork
        {
            get
            {
                if (unitOFWork is null)
                {
                    unitOFWork = new UnitOfWork();
                }
                return unitOFWork;
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            (classManagementView as Form)?.Dispose();
            (attendanceListView as Form)?.Dispose();
            (searchView as Form)?.Dispose();
            (userManagementView as Form)?.Dispose();

            NameMenuItem.Text = "LOGIN";
            RoleTextBox.Text = String.Empty;
            UserManagmentButton.Visible = false;
            ClassManagementButton.Visible = false;
            AttendanceListButton.Visible = false;
            DisplayDataButton.Visible = false;


            LoadLoginForm();
        }
    }
}