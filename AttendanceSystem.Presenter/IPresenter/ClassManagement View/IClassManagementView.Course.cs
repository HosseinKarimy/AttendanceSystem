using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.ViewModels;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IClassManagementView
{
    public TermCourseModel TermCourse { get; set; }
    public List<CourseModel> Courses { get; set; }
    public List<TermModel> Terms { get; set; }
    public List<TeacherModel> Teachers { get; set; }
    public List<SectionPerWeekModel> SectionsPerWeek { get; set; }

    public event EventHandler CourseSaveEdit;
    public event EventHandler LoadTeachersAndCoursesAndTerms;

}
