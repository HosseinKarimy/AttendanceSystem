using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.OtherManagementView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter
{
    public partial class OtherManagementPresenter
    {
        private readonly IOtherManagementView otherManagementView;
        private readonly IUnitOFWork unitOFWork;

        public OtherManagementPresenter(IOtherManagementView otherManagementView, IUnitOFWork unitOFWork)
        {
            this.otherManagementView = otherManagementView;
            this.unitOFWork = unitOFWork;
            RaiseMajorEvents();
            RaiseDegreeEvents();
            RaiseTermEvents();
        }

    }
}
