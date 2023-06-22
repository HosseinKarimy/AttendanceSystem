using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IStudentRepository : IRepository<StudentModel>
{
    List<StudentModel> GetAllStudentsWithIncludes();
}
