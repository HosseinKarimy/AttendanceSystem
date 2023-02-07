using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;

public class StudentRepository_EfCoreSqlite : Repository_EfCoreSqlite<StudentModel>, IStudentRepository
{
    private readonly AppDbContext dbContext;

    public StudentRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<StudentModel> GetAllStudentsWithIncludes()
    {
        return dbContext.Students.Include(u => u.Courses).ThenInclude(u => u.Sections).ThenInclude(u => u.StudentsStatus).ToList();
    }
}
