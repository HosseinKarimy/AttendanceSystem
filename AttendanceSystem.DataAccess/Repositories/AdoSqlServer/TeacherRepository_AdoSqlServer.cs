using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class TeacherRepository_AdoSqlServer : Repository_AdoSqlServer<TeacherModel>, ITeacherRepository
{
    private readonly AppDbContext dbContext;

    public TeacherRepository_AdoSqlServer(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<TeacherModel> GetAllTeachersWithIncludes()
    {
        return dbContext.Teachers.Include(u => u.Courses).ThenInclude(c => c.Sections).ThenInclude(s => s.StudentsStatus).ThenInclude(u => u.Student).ThenInclude(u => u.Courses).ToList();
    }
}
