using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface IStudentDetailsView
{
    StudentModel StudentModel { get; set; }
}
