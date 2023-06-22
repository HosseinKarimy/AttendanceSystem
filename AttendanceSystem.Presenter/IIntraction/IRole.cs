using AttendanceSystem.Models.EfCore_Sqllite.Enums;
using AttendanceSystem.Models.EfCore_Sqllite.Models;

namespace AttendanceSystem.Presenter.IIntraction;

public interface IRole
{
    public Role Role { get; init; }
    public UserModel CurrentUser { get; init; }
}
