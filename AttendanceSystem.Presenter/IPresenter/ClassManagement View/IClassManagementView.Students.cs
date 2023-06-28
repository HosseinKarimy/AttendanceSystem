using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Search_Models;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IClassManagementView
{
    public List<StudentInfoModel> Students { get; set; }
    public List<MajorModel> Majors { get; set; }
    public List<DegreeModel> Degrees { get; set; }
    public SearchStudentModel SearchStudentModel { get; set; }

    public event EventHandler LoadStudents;
    public event EventHandler LoadDegreesAndMajors;
    public event EventHandler SearchStudents;
}
