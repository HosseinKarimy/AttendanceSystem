using AttendanceSystem.Models.Models;
using AttendanceSystem.Models.Search_Models;
using Models.Models;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface ISearchView
{
    public SearchStudentStatusesModel SearchSectionModel { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }

    public List<CourseModel> AllCourses { get; set; }
    public List<TeacherModel> AllTeachers { get; set; }
}
