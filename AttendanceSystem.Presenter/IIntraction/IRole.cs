using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;

namespace AttendanceSystem.Presenter.IInteraction;

public interface IRole
{
    public Role Role { get; init; }
    public UsersModel CurrentUser { get; init; }
}
