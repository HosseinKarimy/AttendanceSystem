using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class SectionRepository_AdoSqlServer : Repository_AdoSqlServer<SectionModel>, ISectionRepository
{
}
