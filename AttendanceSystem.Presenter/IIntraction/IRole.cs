using AttendanceSystem.Models.EfCore_Sqllite.Models;
using AttendanceSystem.Models.Enums;

namespace AttendanceSystem.Presenter.IIntraction;

public interface IRole
{
    public Role Role { get; init; }
    public UserModel CurrentUser { get; init; }
}
