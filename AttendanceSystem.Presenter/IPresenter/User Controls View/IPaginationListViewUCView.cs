using AttendanceSystem.Models.Ado_SqlServer.Views;
using System.Data;

namespace AttendanceSystem.Presenter.IPresenter.User_Controls_View;

public interface IPaginationListViewUCView
{
    public DataTable DataTable { get; set; }
    public Type ModelType { get; set; }
    public string TableName { get; set; }
    public string OrderBy_ColumnName { get; set; }
    public string SearchBy_ColumnName { get; set; }
    public string SearchString { get; set; }

    public event EventHandler LoadData;
}
