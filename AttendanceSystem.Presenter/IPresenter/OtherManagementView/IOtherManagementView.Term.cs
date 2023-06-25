using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<TermModel> Terms { get; set; }
    public TermModel TermModel { get; set; }

    public event EventHandler LoadTerms;
    public event EventHandler DeleteTerm;
    public event EventHandler SaveCreateTerm;
}
