using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite
{
    public class UserRepository_EfCoreSqlite : Repository_EfCoreSqlite<UserModel>, IUserRepository
    {
        public UserRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
