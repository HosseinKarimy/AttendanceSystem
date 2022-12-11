using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories;

public class StudentRepository : Repository<StudentModel>, IStudentRepository
{
    private readonly AppDbContext dbContext;

    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<StudentModel> GetAllStudentsWithIncludes()
    {
        return dbContext.Students.Include(u => u.Courses).ThenInclude(u => u.Sections).ThenInclude(u => u.StudentsStatus).ToList();
    }
}
