using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.Presenter.ClassManegementPresenter
{
    public partial class ClassManegementPresenter
    {
        private readonly IClassManagementView view;
        private readonly IUnitOFWork unitOFWork;

        public ClassManegementPresenter(IClassManagementView view,IUnitOFWork unitOFWork)
        {
            this.view = view;
            this.unitOFWork = unitOFWork;
            RaiseStudentSectionEvents();
            RaiseCourseEvents();
        }
 
    }
}
