using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using AttendanceSystem.Presenter.Presenter.ClassManegementPresenter;
using AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;
using AttendanceSystem.Presenter.Presenter.UserManagementPresenter;

namespace AttendanceSystem.WinFormUI
{
    public partial class MainForm : Form , IMainMenuView
    {
              

        public MainForm()
        {
            InitializeComponent();
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
                    attendanceListView = new AttendanceListForm();
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

    }
}