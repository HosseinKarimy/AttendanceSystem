using AttendanceSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter
{
    public interface IStudentStatusUCView
    {
        public StudentStatusModel StudentStatusModel { get; set; }

        public event EventHandler ShowStudentDetails;
    }
}
