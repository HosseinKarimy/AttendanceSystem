using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter
{
    public partial class OtherManagementPresenter
    {
        private void RaiseMajorEvents()
        {
            otherManagementView.LoadMajors += OtherManagementView_LoadMajors;
        }

        private void OtherManagementView_LoadMajors(object? sender, EventArgs e)
        {
            
        }
    }
}
