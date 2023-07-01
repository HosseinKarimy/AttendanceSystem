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
        ReloadMajorForm();
    }

    private void ReloadMajorForm()
    {
        MajorNameTextBox.Clear();
        MajorSearchTextBox.Clear();
        MajorCreateSaveButton.Text = "Create";
        ActionType = ActionType.Create;

        LoadMajors?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadMajorsInListView(Majors);
    }

    private void LoadMajorsInListView(List<MajorModel> majors)
    {
        MajorListView.Clear();
        MajorListView.View = View.Details;
        MajorListView.SetHeaders(new string[] { "MajorID", "Name" });

        foreach (var item in majors)
        {
            var temp = new ListViewItem(new string[] { item.MajorID.ToString(), item.Name })
            {
                Tag = item
            };
            MajorListView.Items.Add(temp);
        }
        MajorListView.SetSize();
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
            ReloadMajorForm();
    }

    private void MajorListView_ItemActivate(object sender, EventArgs e)
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
        try
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
                ReloadMajorForm();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Select 1 Row For Delete!", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

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
        ReloadDegreeForm();
    }

    private void LoadDegreesInListView(List<DegreeModel> degrees)
    {
        DegreeListView.Clear();
        DegreeListView.View = View.Details;
        DegreeListView.SetHeaders(new string[] { "MajorID", "Name" });
        foreach (var item in degrees)
        {
            var temp = new ListViewItem(new string[] { item.DegreeID.ToString(), item.Name })
            {
                Tag = item
            };
            DegreeListView.Items.Add(temp);
        }
        DegreeListView.SetSize();
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
            ReloadDegreeForm();
    }

    private void DegreeListView_ItemActivate(object sender, EventArgs e)
    {
        DegreeSaveCreateButton.Text = "Update";
        ActionType = ActionType.Update;
        LoadSelectedDegreeInForm((DegreeListView.SelectedItems[0].Tag as DegreeModel));
    }

    private void LoadSelectedDegreeInForm(DegreeModel? degreeModel)
    {
        DegreeNameTextBox.Text = degreeModel?.Name;
    }

    private void DegreeDeleteButton_Click(object sender, EventArgs e)
    {
        try
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
                ReloadDegreeForm();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Select 1 Row For Delete!", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void ReloadDegreeForm()
    {
        DegreeNameTextBox.Clear();
        DegreeSearchTextBox.Clear();
        DegreeSaveCreateButton.Text = "Create";
        ActionType = ActionType.Create;

        LoadDegrees?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadDegreesInListView(Degrees);
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
        ReloadTermForm();
    }

    private void LoadTermsInListView(List<TermModel> terms)
    {
        TermsListView.Clear();
        TermsListView.View = View.Details;
        TermsListView.SetHeaders(new string[] { "TermID", "StartDate" });
        foreach (var item in terms)
        {
            var temp = new ListViewItem(new string[] { item.TermID.ToString(), item.StartDate.ToString() })
            {
                Tag = item
            };
            TermsListView.Items.Add(temp);
        }
        TermsListView.SetSize();
    }

    private void TermSaveCreateButton_Click(object sender, EventArgs e)
    {
        switch (ActionType)
        {
            case ActionType.Create:
                TermModel = new TermModel(Convert.ToInt32(TermIDNumericUpDown.Value), TermStartDateTimePicker.Value);
                break;
            case ActionType.Update:
                //ToDo - بتونه ترم ای دی رو اپدیت کنه؟
                TermModel = (TermsListView.SelectedItems[0].Tag as TermModel)! with { StartDate = TermStartDateTimePicker.Value };
                break;
        }
        SaveCreateTerm?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
            ReloadTermForm();
    }

    private void TermDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            TermModel = (TermsListView.SelectedItems[0].Tag as TermModel)! with { StartDate = TermStartDateTimePicker.Value };
            var result = MessageBox.Show($"Are you sure for delete {TermModel.TermID} ?", "Delete Term", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                DeleteTerm?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                if (IsSucess)
                {
                    //reload list view
                }
                ReloadTermForm();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Select 1 Row For Delete!", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void ReloadTermForm()
    {
        TermIDNumericUpDown.Value = 0;
        TermIDNumericUpDown.ReadOnly = false;
        TermStartDateTimePicker.Value = DateTime.Now;
        TermSaveCreateButton.Text = "Create";
        ActionType = ActionType.Create;

        LoadTerms?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadTermsInListView(Terms);
    }

    private void TermsListView_ItemActivate(object sender, EventArgs e)
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

    #region CourseTabPage
    public List<CourseModel> Courses { get ; set ; }
    public CourseModel CourseModel { get; set; }

    public event EventHandler LoadCourses;
    public event EventHandler DeleteCourse;
    public event EventHandler SaveCreateCourse;
    
    private void CoursesTabPage_Enter(object sender, EventArgs e)
    {
        ReloadCourseForm();
    }

    private void CourseSaveCreateButton_Click(object sender, EventArgs e)
    {
        switch (ActionType)
        {
            case ActionType.Create:
                CourseModel = new CourseModel(0, CourseNameTextBox.Text);
                break;
            case ActionType.Update:
                CourseModel = (CourseListView.SelectedItems[0].Tag as CourseModel)! with { Name = CourseNameTextBox.Text };
                break;
        }
        SaveCreateCourse?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
        if (IsSucess is true)
            ReloadCourseForm();
    }

    private void CourseDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            CourseModel = (CourseListView.SelectedItems[0].Tag as CourseModel)! with { Name = CourseNameTextBox.Text };
            var result = MessageBox.Show($"Are you sure for delete {CourseModel.Name} ?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                DeleteCourse?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                if (IsSucess)                
                    ReloadCourseForm();

                
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Select 1 Row For Delete!", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void ReloadCourseForm()
    {
        CourseNameTextBox.Clear();
        CourseSearchTextBox.Clear();
        CourseSaveCreateButton.Text = "Create";
        ActionType = ActionType.Create;

        LoadCourses?.Invoke(this, EventArgs.Empty);
        if (IsSucess is false)
            MessageBox.Show(Message);
        else
            LoadCoursesInListView(Courses);
    }

    private void LoadCoursesInListView(List<CourseModel> courses)
    {
        CourseListView.Clear();
        CourseListView.View = View.Details;
        CourseListView.SetHeaders(new string[] { "MajorID", "Name" });
        foreach (var item in Courses)
        {
            var temp = new ListViewItem(new string[] { item.CourseID.ToString(), item.Name })
            {
                Tag = item
            };
            CourseListView.Items.Add(temp);
        }
        CourseListView.SetSize();
    }

    private void CoursesListView_ItemActivate(object sender, EventArgs e)
    {
        CourseSaveCreateButton.Text = "Update";
        ActionType = ActionType.Update;
        LoadSelectedCourseInForm((CourseListView.SelectedItems[0].Tag as CourseModel));
    }

    private void LoadSelectedCourseInForm(CourseModel? courseModel)
    {
        CourseNameTextBox.Text = CourseModel?.Name;
    }
    #endregion
}



