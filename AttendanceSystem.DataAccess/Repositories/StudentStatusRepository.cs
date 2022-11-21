using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.DataAccess.Repositories;

public class StudentStatusRepository : Repository<StudentStatusModel>, IStudentStatusRepository
{
    public StudentStatusRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
