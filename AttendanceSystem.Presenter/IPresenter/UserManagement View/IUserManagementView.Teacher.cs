using AttendanceSystem.Models.EfCore_Sqllite.Models;
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
        public List<TeacherModel> Teachers { get; set; }

        public event EventHandler LoadTeachers;
        public event EventHandler TeacherSaveEdit;
        public event EventHandler TeacherDelete;
    }
}
