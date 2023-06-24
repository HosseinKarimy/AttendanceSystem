using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IPresenter.OtherManagementView;

namespace AttendanceSystem.WinFormUI;

public partial class OtherManagementForm : Form, IOtherManagementView
{
    public OtherManagementForm()
    {
        InitializeComponent();
    }                                 

    public List<MajorModel> Majors  { get; set; }
    public List<DegreeModel> Degrees  { get; set; }
    public DegreeModel DegreeModel   { get; set; }
    public List<TermModel> Terms { get; set; }
    public bool IsSucess  { get; set; }
    public string Message  { get; set; }
    public ActionType ActionType { get; set; }

    public event EventHandler LoadMajors;

    public event EventHandler LoadTerms;


    #region MajorTabPage

    private void MajorCreateSaveButton_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region DegreeTabPage
    public event EventHandler LoadDegrees;
    public event EventHandler DeleteDegree;
    public event EventHandler SaveCreateDegree;

    private void DegreeSaveCreateButton_Click(object sender, EventArgs e)
    {
        ActionType = ActionType.Create;
        DegreeModel = new DegreeModel(0,DegreeNameTextBox.Text);
        SaveCreateDegree?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
        {
            ClearDegreeForm();
        }
    }

    private void ClearDegreeForm()
    {
        DegreeNameTextBox.Clear();
    }

    #endregion
}
