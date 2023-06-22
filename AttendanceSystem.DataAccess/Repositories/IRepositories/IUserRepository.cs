using AttendanceSystem.Models.EfCore_Sqllite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories
{
    public interface IUserRepository : IRepository<UserModel>
    {
    }
}
