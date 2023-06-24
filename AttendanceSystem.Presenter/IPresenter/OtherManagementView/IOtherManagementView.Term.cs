using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<TermModel> Terms { get; set; }
    public event EventHandler LoadTerms;
}
