using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter
{
    public partial interface IUserManagementView
    {
        public TeacherModel TeacherModel { get; set; }

        public event EventHandler TeaherSaveEdit;
        public event EventHandler TeaCherDelete;
    }
}
