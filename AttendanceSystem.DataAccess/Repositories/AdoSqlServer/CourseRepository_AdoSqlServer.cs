using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class CourseRepository_AdoSqlServer : Repository_AdoSqlServer<CourseModel>, ICourseRepository
{
    public CourseRepository_AdoSqlServer(AppDbContext dbContext) : base(dbContext)
    {
    }
}
