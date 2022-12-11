using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IStudentRepository : IRepository<StudentModel>
{
    List<StudentModel> GetAllStudentsWithIncludes();
}
