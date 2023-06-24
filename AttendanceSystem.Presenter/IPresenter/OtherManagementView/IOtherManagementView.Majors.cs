using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<MajorModel> Majors { get; set; }
    public event EventHandler LoadMajors;
}
