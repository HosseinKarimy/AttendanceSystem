using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter;
using System.Windows.Forms;

namespace AttendanceSystem.WinFormUI;

public partial class StudentStatusUserControl : UserControl, IStudentStatusUCView
{
    public StudentStatusUserControl()
    {
        InitializeComponent();
    }


    public bool IsReadOnly { get; set; } = false;
    public StudentStatusModel StudentStatusModel { get; set; }
    public StudentFullInfoModel StudentFullInfoModel { get; set; }

    public event EventHandler ChangePresentStatus;

    private void DescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (DescriptionCheckBox.Checked)
        {
            this.Height = 59;
        }
        else
        {
            this.Height = 32;
        }
    }

    private void PresentCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (PresentCheckBox.Checked)
            MainPanel.BackColor = Color.LightGreen;
        else
            MainPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF5859");
        if (IsReadOnly is false)
        {
            StudentStatusModel.IsPresent = PresentCheckBox.Checked;
            ChangePresentStatus?.Invoke(StudentStatusModel, EventArgs.Empty);
        }
    }

    private void StudentStatusUserControl_Load(object sender, EventArgs e)
    {
        NameTextBox.Text = StudentFullInfoModel.FirstName;
        StudentIdTextBox.Text = StudentFullInfoModel.StudentID.ToString();
        DescriptionTextBox.Text = StudentStatusModel.Description;
        if (StudentStatusModel.IsPresent is not null)
        {
            PresentCheckBox.CheckState = (bool)StudentStatusModel.IsPresent ? CheckState.Checked : CheckState.Unchecked;
            PresentCheckBox_CheckedChanged(sender, e);
        }
        if (IsReadOnly is true)
            PresentCheckBox.Enabled = false;
        if (!string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            DescriptionCheckBox.CheckState = CheckState.Indeterminate;
    }

    private void ShowStudentDetailsButton_Click(object sender, EventArgs e)
    {
        var newDetailForm = FormContainer.StudentDetailsView;
        newDetailForm.StudentFullInfoModel = StudentFullInfoModel;
        (newDetailForm as Form)?.ShowDialog();
    }

    private void DescriptionTextBox_Leave(object sender, EventArgs e)
    {
        StudentStatusModel.Description = DescriptionTextBox.Text;
    }
}
