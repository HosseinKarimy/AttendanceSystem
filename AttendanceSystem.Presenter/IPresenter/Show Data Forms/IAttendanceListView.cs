using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Presenter.IInteraction;
using AttendanceSystem.Presenter.IPresenter.Common;

namespace AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

public interface IAttendanceListView : IResultFeedback , IRole
{
    public List<TeacherModel> Teachers { get; set; }
    public TeacherModel SelectedTeacher { get; set; }
    public List<TermCourseDetailsModel> TermCoursesOfTeacher { get; set; }
    public TermCourseDetailsModel SelectedTermCourse { get; set; }
    public List<SectionModel> Sections { get; set; }
    public SectionModel SelectedSection { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }
    public StudentFullInfoModel StudentFullInfo { get; set; }

    public event EventHandler LoadTeachers;
    public event EventHandler LoadTermCoursesOfTeacher;
    public event EventHandler LoadSectionsOfTermCourse;
    public event EventHandler LoadStudentsStatusOfSection;
    public event EventHandler LoadStudentsFullInfo;
    public event EventHandler UpdateSection;
}
