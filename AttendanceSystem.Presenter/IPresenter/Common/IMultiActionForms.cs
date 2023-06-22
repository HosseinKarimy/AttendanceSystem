using AttendanceSystem.Models.EfCore_Sqllite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter.Common
{
    public interface IMultiActionForms
    {
        public ActionType ActionType { get; set; }
    }
}
