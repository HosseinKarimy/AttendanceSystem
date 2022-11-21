using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories;

public class StudentRepository : Repository<StudentModel>, IStudentRepository
{
    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
