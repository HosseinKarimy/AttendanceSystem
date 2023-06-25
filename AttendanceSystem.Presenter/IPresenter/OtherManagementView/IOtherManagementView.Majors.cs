using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<MajorModel> Majors { get; set; }
    public MajorModel MajorModel { get; set; }

    public event EventHandler LoadMajors;
    public event EventHandler DeleteMajor;
    public event EventHandler SaveCreateMajor;
}
