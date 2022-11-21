using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories;

public class CourseRepository : Repository<CourseModel>, ICourseRepository
{
    public CourseRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
