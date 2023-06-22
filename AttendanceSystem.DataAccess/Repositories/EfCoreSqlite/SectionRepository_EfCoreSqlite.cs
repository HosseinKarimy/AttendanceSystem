using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;

public class SectionRepository_EfCoreSqlite : Repository_EfCoreSqlite<SectionModel>, ISectionRepository
{
    public SectionRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
    {
    }
}
