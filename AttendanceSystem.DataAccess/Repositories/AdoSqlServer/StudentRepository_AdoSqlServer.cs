using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.EfCoreSqlite;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using AttendanceSystem.Models.EfCore_Sqllite.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem.DataAccess.Repositories.AdoSqlServer;

public class StudentRepository_AdoSqlServer : Repository_AdoSqlServer<StudentModel>, IStudentRepository
{
    public List<StudentModel> GetAllStudentsWithIncludes()
    {
        throw new NotImplementedException();
    }
}
