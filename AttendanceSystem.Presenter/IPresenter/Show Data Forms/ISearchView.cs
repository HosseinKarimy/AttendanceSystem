using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface ISearchView
{
    public List<TeacherModel> AllTeachers { get; set; }
    public List<TermCourseDetailsModel> TermCoursesOfTeacher { get; set; }
    public List<SectionModel> Sections { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }
    

    public event EventHandler LoadTeachers;
}
