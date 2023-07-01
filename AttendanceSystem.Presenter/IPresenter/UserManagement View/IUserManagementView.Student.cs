using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IUserManagementView
{
    public StudentModel StudentModel { get; set; }
    public List<StudentModel> Students { get; set; }
    public List<MajorModel> Majors  { get; set; }
    public List<DegreeModel> Degrees { get; set; }

    public event EventHandler LoadMajorAndDegree;
    public event EventHandler LoadStudents;
    public event EventHandler StudentSaveEdit;
    public event EventHandler StudentDelete;
}
