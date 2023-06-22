using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;

public class TeacherRepository_EfCoreSqlite : Repository_EfCoreSqlite<TeacherModel>, ITeacherRepository
{
    private readonly AppDbContext dbContext;

    public TeacherRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<TeacherModel> GetAllTeachersWithIncludes()
    {
        return dbContext.Teachers.Include(u => u.Courses).ThenInclude(c => c.Sections).ThenInclude(s => s.StudentsStatus).ThenInclude(u => u.Student).ThenInclude(u => u.Courses).ToList();
    }
}
