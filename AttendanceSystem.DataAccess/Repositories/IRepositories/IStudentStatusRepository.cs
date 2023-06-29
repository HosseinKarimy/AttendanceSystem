using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IStudentStatusRepository : IRepository<StudentStatusModel>
{
    List<StudentStatusModel> GetStudentStatusesBySectionID(int SectionID);
    List<StudentStatusInfoPerTermCourse> StudentStatusesInfo_TermCourseAndStudent(int StudentID, int TermCourseID);
}
