using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class TeacherRepository_AdoSqlServer : Repository_AdoSqlServer<TeacherModel>, ITeacherRepository
{
    public List<TeacherModel> GetAllTeachersWithIncludes()
    {
        throw new NotImplementedException();
    }
}
