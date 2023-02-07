using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer
{
    public class UserRepository_AdoSqlServer : Repository_AdoSqlServer<UserModel>, IUserRepository
    {
        public UserRepository_AdoSqlServer(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
