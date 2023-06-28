using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter;

namespace AttendanceSystem.Presenter.Presenter.ClassManagementPresenter;

public partial class ClassManagementPresenter
{
    private readonly IClassManagementView view;
    private readonly IUnitOFWork unitOFWork;

    public ClassManagementPresenter(IClassManagementView view,IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;
        RaiseStudentSectionEvents();
        RaiseCourseEvents();
    }

}
