using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface ITermCourseRepository : IRepository<TermCourseModel>
{
    List<TermCourseDetailsModel> GetTermCoursesByTeacherID(int TeacherID);
    List<TermCourseDetailsModel> GetTermCoursesByStudentID(int StudentID);
}
