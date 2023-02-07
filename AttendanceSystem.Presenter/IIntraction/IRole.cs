using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.Models;

namespace AttendanceSystem.Presenter.IIntraction;

public interface IRole
{
    public Role Role { get; init; }
    public UserModel CurrentUser { get; init; }
}
