using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface ITeacherRepository : IRepository<TeacherModel>
{
    List<TeacherModel> GetAllTeachersWithIncludes();
}
