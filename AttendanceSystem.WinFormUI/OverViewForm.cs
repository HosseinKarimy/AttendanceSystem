using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

namespace AttendanceSystem.WinFormUI;

public partial class OverViewForm : Form, IOverviewForm
{
    public OverViewForm()
    {
        InitializeComponent();
    }

    private void OverViewForm_Load(object sender, EventArgs e)
    {
        var StudentForm = FormContainer.PaginationListViewUCView;
        StudentForm.TableName = "Students_Info";
        StudentForm.ModelType = typeof(StudentInfoModel);
        (StudentForm as UserControl)!.Dock = DockStyle.Fill;
        splitContainer1.Panel1.Controls.Add((Control)StudentForm);

        var TeacherForm = FormContainer.PaginationListViewUCView;
        TeacherForm.TableName = "Teacher";
        TeacherForm.ModelType = typeof(TeacherModel);
        (TeacherForm as UserControl)!.Dock = DockStyle.Fill;
        splitContainer1.Panel2.Controls.Add((Control)TeacherForm);
    }
}
