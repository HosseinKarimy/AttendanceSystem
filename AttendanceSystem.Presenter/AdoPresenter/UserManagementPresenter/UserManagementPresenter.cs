namespace AttendanceSystem.Presenter.AdoPresenter.UserManagementPresenter;

public partial class UserManagementPresenter
{
	private readonly IUserManagementView userManagementView;
	private readonly IUnitOFWork unitOFWork;

	public UserManagementPresenter(IUserManagementView userManagementView , IUnitOFWork unitOFWork)
	{
		this.userManagementView = userManagementView;
		this.unitOFWork = unitOFWork;
		RaiseStudentsEvents();
        RaiseTeachersEvents();
    }
}
