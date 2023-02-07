using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class StudentStatusRepository_AdoSqlServer : Repository_AdoSqlServer<StudentStatusModel>, IStudentStatusRepository
{
}
