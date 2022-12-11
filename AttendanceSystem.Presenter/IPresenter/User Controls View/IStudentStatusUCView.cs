using AttendanceSystem.Models.Models;

namespace AttendanceSystem.Presenter.IPresenter
{
    public interface IStudentStatusUCView
    {
        public StudentStatusModel StudentStatusModel { get; set; }

        public event EventHandler ShowStudentDetails;
        public event EventHandler ChangePresentStatus;
    }
}
