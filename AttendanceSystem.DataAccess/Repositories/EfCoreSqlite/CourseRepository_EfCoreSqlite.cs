using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;

public class CourseRepository_EfCoreSqlite : Repository_EfCoreSqlite<CourseModel>, ICourseRepository
{
    public CourseRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
    {
    }
}
