using AttendanceSystem.Models.Ado_SqlServer;
using System.Reflection.Metadata.Ecma335;

namespace AttendanceSystem.Presenter.IPresenter.OtherManagementView;

public partial interface IOtherManagementView
{
    public List<DegreeModel> Degrees { get; set; }
    public DegreeModel DegreeModel { get; set; }

    public event EventHandler LoadDegrees;
    public event EventHandler DeleteDegree;
    public event EventHandler SaveCreateDegree;

}
