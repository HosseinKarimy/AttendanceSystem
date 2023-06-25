using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IPresenter.OtherManagementView;
using System.Configuration;

namespace AttendanceSystem.WinFormUI;

public partial class OtherManagementForm : Form, IOtherManagementView
{
    public OtherManagementForm()
    {
        InitializeComponent();
    }

    public bool IsSucess { get; set; }
    public string Message { get; set; }
    public ActionType ActionType { get; set; }

    #region MajorTabPage
    public List<MajorModel> Majors { get; set; }
    public MajorModel MajorModel { get; set; }


    public event EventHandler LoadMajors;
    public event EventHandler DeleteMajor;
    public event EventHandler SaveCreateMajor;


    private void MajorTabPage_Enter(object sender, EventArgs e)
    {
        ClearMajorForm();
        LoadMajors?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadMajorsInListView(Majors);
    }

    private void LoadMajorsInListView(List<MajorModel> majors)
    {

        MajorListView.Clear();

        foreach (var item in majors)
        {
            var temp = new ListViewItem(new string[] { item.MajorID.ToString(), item.Name })
            {
                Tag = item
            };
            MajorListView.Items.Add(temp);
        }
    }

    private void MajorCreateSaveButton_Click(object sender, EventArgs e)
    {
        switch (ActionType)
        {
            case ActionType.Create:
                MajorModel = new MajorModel(0, MajorNameTextBox.Text);
                break;
            case ActionType.Update:
                MajorModel = (MajorListView.SelectedItems[0].Tag as MajorModel)! with { Name = MajorNameTextBox.Text };
                break;
        }
        SaveCreateMajor?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
            ClearMajorForm();
    }

    private void MajorListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        MajorCreateSaveButton.Text = "Update";
        ActionType = ActionType.Update;
        LoadSelectedMajorInForm(MajorListView.SelectedItems[0].Tag as MajorModel);
    }

    private void LoadSelectedMajorInForm(MajorModel? majorModel)
    {
        MajorNameTextBox.Text = majorModel?.Name;
    }

    private void MajorDeleteButton_Click(object sender, EventArgs e)
    {
        MajorModel = (MajorListView.SelectedItems[0].Tag as MajorModel)! with { Name = MajorNameTextBox.Text };
        var result = MessageBox.Show($"Are you sure for delete {MajorModel.Name} ?", "Delete Major", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        if (result == DialogResult.Yes)
        {
            DeleteMajor?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
            if (IsSucess)
            {
                //reload list view
            }
            ClearMajorForm();
        }
    }

    private void ClearMajorForm()
    {
        MajorNameTextBox.Clear();
        MajorSearchTextBox.Clear();
        MajorCreateSaveButton.Text = "Create";
        ActionType = ActionType.Create;
    }

    //Todo - Search For Majors

    #endregion

    #region DegreeTabPage
    public List<DegreeModel> Degrees { get; set; }
    public DegreeModel DegreeModel { get; set; }


    public event EventHandler LoadDegrees;
    public event EventHandler DeleteDegree;
    public event EventHandler SaveCreateDegree;

    private void DegreeTabPage_Enter(object sender, EventArgs e)
    {
        ClearDegreeForm();
        LoadDegrees?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadDegreesInListView(Degrees);
    }

    private void LoadDegreesInListView(List<DegreeModel> degrees)
    {
        DegreeListView.Clear();

        foreach (var item in degrees)
        {
            var temp = new ListViewItem(new string[] { item.DegreeID.ToString(), item.Name })
            {
                Tag = item
            };
            DegreeListView.Items.Add(temp);
        }
    }

    private void DegreeSaveCreateButton_Click(object sender, EventArgs e)
    {
        switch (ActionType)
        {
            case ActionType.Create:
                DegreeModel = new DegreeModel(0, DegreeNameTextBox.Text);
                break;
            case ActionType.Update:
                DegreeModel = (DegreeListView.SelectedItems[0].Tag as DegreeModel)! with { Name = DegreeNameTextBox.Text };
                break;
        }
        SaveCreateDegree?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
            ClearDegreeForm();
    }
    private void DegreeListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        DegreeSaveCreateButton.Text = "Update";
        ActionType = ActionType.Update;
        LoadDegreeInForm((DegreeListView.SelectedItems[0].Tag as DegreeModel));
    }

    private void LoadDegreeInForm(DegreeModel? degreeModel)
    {
        DegreeNameTextBox.Text = degreeModel?.Name;
    }

    private void DegreeDeleteButton_Click(object sender, EventArgs e)
    {
        DegreeModel = (DegreeListView.SelectedItems[0].Tag as DegreeModel)! with { Name = DegreeNameTextBox.Text };
        var result = MessageBox.Show($"Are you sure for delete {DegreeModel.Name} ?", "Delete Degree", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        if (result == DialogResult.Yes)
        {
            DeleteDegree?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
            if (IsSucess)
            {

            }
            ClearDegreeForm();
        }
    }

    private void ClearDegreeForm()
    {
        DegreeNameTextBox.Clear();
        DegreeSearchTextBox.Clear();
        DegreeSaveCreateButton.Text = "Create";
        ActionType = ActionType.Create;
    }

    //TODO - Search for Degrees
    #endregion

    #region TermTabPage
    public List<TermModel> Terms { get; set; }
    public TermModel TermModel { get; set; }

    public event EventHandler LoadTerms;
    public event EventHandler DeleteTerm;
    public event EventHandler SaveCreateTerm;

    private void TermTabPage_Enter(object sender, EventArgs e)
    {
        ClearTermForm();        
        LoadTerms?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadTermsInListView(Terms);
    }

    private void LoadTermsInListView(List<TermModel> terms)
    {
        TermsListView.Clear();

        foreach (var item in terms)
        {
            var temp = new ListViewItem(new string[] { item.TermID.ToString(), item.StartDate.ToString() })
            {
                Tag = item
            };
            TermsListView.Items.Add(temp);
        }
    }

    private void TermSaveCreateButton_Click(object sender, EventArgs e)
    {
        switch (ActionType)
        {
            case ActionType.Create:
                TermModel = new TermModel(Convert.ToInt32(TermIDNumericUpDown.Value),TermStartDateTimePicker.Value);
                break;
            case ActionType.Update:
                //ToDo - بتونه ترم ای دی رو اپدیت کنه؟
                TermModel = (DegreeListView.SelectedItems[0].Tag as TermModel)! with { StartDate = TermStartDateTimePicker.Value };
                break;
        }
        SaveCreateDegree?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
            ClearDegreeForm();
    }

    private void TermDeleteButton_Click(object sender, EventArgs e)
    {

        TermModel = (MajorListView.SelectedItems[0].Tag as TermModel)! with { StartDate = TermStartDateTimePicker.Value };
        var result = MessageBox.Show($"Are you sure for delete {TermModel.TermID} ?", "Delete Term", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        if (result == DialogResult.Yes)
        {
            DeleteTerm?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
            if (IsSucess)
            {
                //reload list view
            }
            ClearTermForm();
        }
    }

    private void ClearTermForm()
    {
        TermIDNumericUpDown.Value = 0;
        TermIDNumericUpDown.ReadOnly = false;
        TermStartDateTimePicker.Value = DateTime.Now;
        TermSaveCreateButton.Text = "Create";
        ActionType = ActionType.Create;
    }

    private void TermsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        TermSaveCreateButton.Text = "Update";
        ActionType = ActionType.Update;
        LoadSelectedTermInForm(TermsListView.SelectedItems[0].Tag as TermModel);
    }

    private void LoadSelectedTermInForm(TermModel? termModel)
    {
        TermIDNumericUpDown.Value = Convert.ToDecimal(termModel?.TermID);
        TermIDNumericUpDown.ReadOnly = true;
        TermStartDateTimePicker.Value = termModel?.StartDate ?? DateTime.Now;
    }

    //TODO - Search for Terms
    #endregion
}
