using AttendanceSystem.Models.Models;
using AttendanceSystem.Models.Search_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms
{
    public interface IAttendanceListView
    {
        public SearchStudentStatusesModel SearchSectionModel { get; set; }
        public List<StudentStatusModel> StudentStatuses { get; set; }

        public event EventHandler CreateNewSection;
    }
}
