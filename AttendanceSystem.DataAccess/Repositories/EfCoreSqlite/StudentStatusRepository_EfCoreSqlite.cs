using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;

public class StudentStatusRepository_EfCoreSqlite : Repository_EfCoreSqlite<StudentStatusModel>, IStudentStatusRepository
{
    public StudentStatusRepository_EfCoreSqlite(AppDbContext dbContext) : base(dbContext)
    {
    }
}
