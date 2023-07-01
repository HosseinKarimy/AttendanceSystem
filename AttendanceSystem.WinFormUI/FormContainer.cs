using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter;
using AttendanceSystem.Presenter.AdoPresenter.Show_Data_Forms_Presenter;
using AttendanceSystem.Presenter.AdoPresenter.UserControlsPresenter;
using AttendanceSystem.Presenter.AdoPresenter.UserManagementPresenter;
using AttendanceSystem.Presenter.IPresenter;
using AttendanceSystem.Presenter.IPresenter.MainMenuView;
using AttendanceSystem.Presenter.IPresenter.OtherManagementView;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using AttendanceSystem.Presenter.IPresenter.User_Controls_View;
using AttendanceSystem.Presenter.Presenter.ClassManagementPresenter;
using AttendanceSystem.Presenter.Presenter.MainMenuPresenter;
using AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;

namespace AttendanceSystem.WinFormUI;

public static class FormContainer
{

    //Dependency injection

    private static IClassManagementView classManagementView;
    public static IClassManagementView ClassManagementView
    {
        get {
            if (classManagementView is null || (classManagementView as Form)!.IsDisposed)
            {
                classManagementView = new ClassManagementForm();
                new ClassManagementPresenter(classManagementView, UnitOFWork);
            }
            return classManagementView;
        }
    }

    private static IAttendanceListView attendanceListView;
    public static IAttendanceListView AttendanceListView
    {
        get {
            if (attendanceListView is null || (attendanceListView as Form)!.IsDisposed)
            {
                attendanceListView = new AttendanceListForm();
                //{
                //    CurrentUser = UserModel,
                //    //Role = UserModel.Role
                //};
                new AttendanceListPresenter(AttendanceListView, UnitOFWork);
            }
            return attendanceListView;
        }
    }

    //private static ISearchView searchView;
    //public static ISearchView SearchView
    //{
    //    get {
    //        if (searchView is null || (searchView as Form)!.IsDisposed)
    //        {
    //            searchView = new SearchForm();
    //            new SearchPresenter(SearchView, UnitOFWork);
    //        }
    //        return searchView;
    //    }
    //}

    private static IUserManagementView userManagementView;
    public static IUserManagementView UserManagementView
    {
        get {
            if (userManagementView is null || (userManagementView as Form)!.IsDisposed)
            {
                userManagementView = new UserManagement();
                new UserManagementPresenter(userManagementView, UnitOFWork);
            }
            return userManagementView;
        }
    }

    private static ILoginView loginView;
    public static ILoginView LoginView
    {
        get {
            if (loginView is null || (loginView as Form)!.IsDisposed)
            {
                //loginView = new LoginForm(this);
                new LoginPresenter(loginView, UnitOFWork);
            }
            return loginView;
        }
    }

    private static IUnitOFWork unitOFWork;
    public static IUnitOFWork UnitOFWork
    {
        get {
            if (unitOFWork is null)
            {
                unitOFWork = new UnitOfWork();
            }
            return unitOFWork;
        }
    }

    private static IOtherManagementView otherManagementView;
    public static IOtherManagementView OtherManagementView
    {
        get {
            if (otherManagementView is null || (otherManagementView as Form)!.IsDisposed)
            {
                otherManagementView = new OtherManagementForm();
                new OtherManagementPresenter(otherManagementView, UnitOFWork);
            }
            return otherManagementView;
        }
    }

    private static IStudentDetailsView studentDetailsView;
    public static IStudentDetailsView StudentDetailsView
    {
        get {

            //if (studentDetailsView is null || (studentDetailsView as Form)!.IsDisposed)
            //{
                studentDetailsView = new StudentDetailsForm();
                new StudentDetailsPresenter(studentDetailsView, UnitOFWork);
            //}
            return studentDetailsView;
        }
    }

    private static IOverviewForm overviewFormView;
    public static IOverviewForm OverviewFormView
    {
        get {
            if (overviewFormView is null || (overviewFormView as Form)!.IsDisposed)
            {
                overviewFormView = new OverViewForm();
            }
            return overviewFormView;
        }
    }

    private static IPaginationListViewUCView paginationListViewUC;
    public static IPaginationListViewUCView PaginationListViewUCView
    {
        get {
            paginationListViewUC = new PaginationListViewUserControl();
            new PaginationLVUCViewPresenter(paginationListViewUC, UnitOFWork);

            return paginationListViewUC;
        }
    }

}
