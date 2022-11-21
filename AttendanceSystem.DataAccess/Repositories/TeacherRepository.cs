using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories;

public class TeacherRepository : Repository<TeacherModel>, ITeacherRepository
{
    public TeacherRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
