using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class CourseRepository_AdoSqlServer : Repository_AdoSqlServer<CourseModel>, ICourseRepository
{
}
