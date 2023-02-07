using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class SectionRepository_AdoSqlServer : Repository_AdoSqlServer<SectionModel>, ISectionRepository
{
}
