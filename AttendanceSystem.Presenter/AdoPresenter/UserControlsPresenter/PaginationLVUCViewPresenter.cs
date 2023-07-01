using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.User_Controls_View;

namespace AttendanceSystem.Presenter.AdoPresenter.UserControlsPresenter;

public class PaginationLVUCViewPresenter
{
    private readonly IPaginationListViewUCView view;
    private readonly IUnitOFWork unitOFWork;

    public PaginationLVUCViewPresenter(IPaginationListViewUCView view,IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;
        RaiseEvents();
    }

    private void RaiseEvents()
    {
        view.LoadData += LoadData;
    }

    private void LoadData(object? sender, EventArgs e)
    {
        try
        {
            (int offsets, int fetch) = ((int, int))sender!;

           view.DataTable = unitOFWork.AllRepositories.GetSomeDataFromTable(view.TableName,view.OrderBy_ColumnName,view.SearchBy_ColumnName,view.SearchString,offsets,fetch);
        }
        catch (Exception)
        {

        }
    }
}
