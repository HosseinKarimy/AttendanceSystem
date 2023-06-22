using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Presenter.IIntraction;
using AttendanceSystem.Presenter.IPresenter.Common;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface IAttendanceListView : IResultFeedback , IRole
{
    public List<TeacherModel> Teachers { get; set; }
    public SearchStudentStatusesModel SearchSectionModel { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }
    public SectionModel Section { get; set; }

    public event EventHandler LoadTeachers;
    public event EventHandler UpdateSection;
}
