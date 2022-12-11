using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter.MainMenuView
{
    public interface IMainMenuView
    {
        IClassManagementView ClassManagementView { get; }
        IAttendanceListView AttendanceListView { get; }
        ISearchView SearchView { get; }
        IUserManagementView UserManagementView { get; }

        IUnitOFWork UnitOFWork { get; }
    }
}
