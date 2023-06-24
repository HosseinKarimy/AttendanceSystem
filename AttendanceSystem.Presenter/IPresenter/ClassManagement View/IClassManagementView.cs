using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IPresenter.Common;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IClassManagementView : IMultiActionForms , IResultFeedback
{
    public ActionType ActionType { get; set; }
}
