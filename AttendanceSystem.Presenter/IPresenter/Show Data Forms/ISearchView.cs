using AttendanceSystem.Models.Models;
using AttendanceSystem.Models.Search_Models;
using Models.Models;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface ISearchView
{
    public List<StudentModel> AllStudents { get; set; }
    public List<TeacherModel> AllTeachers { get; set; }

    public event EventHandler LoadStudentsAndTeachers;
}
