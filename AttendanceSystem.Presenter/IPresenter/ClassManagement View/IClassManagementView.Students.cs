using AttendanceSystem.Models.Search_Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter
{
    public partial interface IClassManagementView
    {
        public List<StudentModel> Students { get; set; }
        public SearchStudentModel SearchStudentModel { get; set; }

        public event EventHandler LoadStudents;
        public event EventHandler Search;
    }
}
