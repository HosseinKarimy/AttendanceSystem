using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Models.Search_Models
{
    public class SearchStudentStatusesModel
    {
        public TeacherModel Teacher { get; set; }
        public CourseModel Course { get; set; }
        public SectionModel Section { get; set; }
        public SearchPresenceType PresenceType { get; set; }
    }
}
