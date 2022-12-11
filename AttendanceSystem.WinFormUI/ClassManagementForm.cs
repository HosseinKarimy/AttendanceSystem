using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Presenter.IPresenter;
using Models.Enums;
using Models.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceSystem.WinFormUI;

public partial class ClassManagementForm : Form, IClassManagementView
{
    public ClassManagementForm()
    {
        InitializeComponent();
    }

    private void ClassManagementForm_Load(object sender, EventArgs e)
    {
        InitializeStudentSectionTabPage();
        InitializeCourseTabPage();
    }

    public bool IsSucess { get; set; }
    public string Message { get; set; }
    public ActionType ActionType { get; set; } = ActionType.Create;

    #region StudentSectionTabPage

    public List<StudentModel> Students { get; set; } = new();
    public SearchStudentModel SearchStudentModel { get; set; } = new();
    public SectionModel SectionModel { get; set; } = new();
    public event EventHandler Search;
    public event EventHandler LoadStudents;

    private void InitializeStudentSectionTabPage()
    {
        DayOfWeekComboBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
        GradeComboBox.DataSource = Enum.GetValues(typeof(Grade));
        MajorComboBox.DataSource = Enum.GetValues(typeof(Major));

        const int shamsi_miladi_diff = 621;
        EntryYearNumric.Minimum = DateTime.Now.AddYears(-8).Year - shamsi_miladi_diff;
        EntryYearNumric.Maximum = DateTime.Now.Year - shamsi_miladi_diff;
        ClassDurationTimePicker.CustomFormat = "mm:hh";

        SearchStudentTextBox.TextChanged += delegate
        {
            PrepairingSearch();
            Search?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        MajorComboBox.SelectedIndexChanged += delegate
        {
            PrepairingSearch();
            Search?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        GradeComboBox.SelectedIndexChanged += delegate
        {
            PrepairingSearch();
            Search?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        EntryYearCheckBox.CheckedChanged += delegate
        {
            PrepairingSearch();
            Search?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        EntryYearNumric.ValueChanged += delegate
        {
            PrepairingSearch();
            Search?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
    }

    //enter TabPage
    private void StudentSectionTabPage_Enter(object sender, EventArgs e)
    {
        LoadStudents?.Invoke(this, EventArgs.Empty);
        ReloadStudentsInListView(Students);
    }

    private void ReloadStudentsInListView(List<StudentModel> students)
    {
        AllStudentsListView.Columns.Clear();
        AllStudentsListView.Items.Clear();

        AllStudentsListView.View = View.Details;
        AllStudentsListView.Columns.Add("StudentId");
        AllStudentsListView.Columns.Add("Name");
        AllStudentsListView.Columns.Add("Major");
        AllStudentsListView.Columns.Add("Grade");
        AllStudentsListView.Columns.Add("Entry Year");

        foreach (var student in students)
        {
            if (SelectedStudents.Any(u => u.Id == student.Id))
                continue;
            var item = new ListViewItem(new String[] { student.StudentId, student.FullName, student.Major.ToString(), student.Grade.ToString(), student.EntryYear.ToString() });
            item.Tag = student;
            AllStudentsListView.Items.Add(item);
        }
        AllStudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        AllStudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private void PrepairingSearch()
    {
        SearchStudentModel = new()
        {
            SearchString = SearchStudentTextBox.Text,
            Major = (Major)MajorComboBox.SelectedValue,
            Grade = (Grade)GradeComboBox.SelectedValue,
            EntryYear = EntryYearCheckBox.Checked ? (int)EntryYearNumric.Value : 0
        };
    }

    private void EntryYearCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (EntryYearCheckBox.Checked)
        {
            EntryYearNumric.Enabled = true;
        }
        else
        {
            EntryYearNumric.Enabled = false;
        }
    }

    //add students to course
    private void AddStudnetsButton_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in AllStudentsListView.SelectedItems)
        {
            SelectedStudents.Add((item.Tag as StudentModel)!);
        }
        ReloadStudentsInListView(Students);
    }

    //add section to course
    private void AddSectionButton_Click(object sender, EventArgs e)
    {
        var duration = new TimeSpan(ClassDurationTimePicker.Value.Hour % 12, ClassDurationTimePicker.Value.Minute, ClassDurationTimePicker.Value.Second);
        var time = new TimeOnly(SectionTimePicker.Value.Hour, SectionTimePicker.Value.Minute, SectionTimePicker.Value.Second);

        SectionModel = new()
        {
            ClassDuration = duration,
            StartTime = time,
            Day = (DayOfWeek)DayOfWeekComboBox.SelectedItem
        };
        SelectedSections.Add(SectionModel);
    }


    #endregion

    #region CourseTabPage

    //members
    public List<TeacherModel> Teachers { get; set; } = new();
    public List<StudentModel> SelectedStudents { get; set; } = new();
    public List<SectionModel> SelectedSections { get; set; } = new();
    public CourseModel CourseModel { get; set; } = new();

    public event EventHandler CourseSaveEdit;
    public event EventHandler LoadTeachers;

    private void InitializeCourseTabPage()
    {
        RemoveFromSelectedStudentsToolTip.SetToolTip(this.RemoveCheckedStudentsFromSelectedStudentsButton, "Remove Checked Students From Course");
    }

    private void CreateCourseTabPage_Enter(object sender, EventArgs e)
    {
        LoadSelectedStudents();
        LoadSelectedSections();
        LoadTeachersInListView();
    }

    private void LoadTeachersInListView()
    {
        LoadTeachers?.Invoke(this, EventArgs.Empty);
        ReloadTeachersInListView(Teachers);
    }

    private void ReloadTeachersInListView(List<TeacherModel> teachers)
    {
        TeachersListView.Columns.Clear();
        TeachersListView.Items.Clear();

        TeachersListView.View = View.Details;
        TeachersListView.Columns.Add("TeacherId");
        TeachersListView.Columns.Add("Name");

        foreach (var teacher in teachers)
        {
            var item = new ListViewItem(new String[] { teacher.TeacherId, teacher.FullName });
            item.Tag = teacher;
            TeachersListView.Items.Add(item);
        }
        TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private void LoadSelectedStudents()
    {
        SelectedStudentsListView.Columns.Clear();
        SelectedStudentsListView.Items.Clear();

        SelectedStudentsListView.View = View.Details;
        SelectedStudentsListView.Columns.Add("StudentId");
        SelectedStudentsListView.Columns.Add("Name");
        SelectedStudentsListView.Columns.Add("Major");

        foreach (var student in SelectedStudents)
        {
            var item = new ListViewItem(new String[] { student.StudentId, student.FullName, student.Major.ToString() });
            item.Tag = student;
            SelectedStudentsListView.Items.Add(item);
        }
        SelectedStudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        SelectedStudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private void LoadSelectedSections()
    {
        foreach (SectionUserControl usercontrol in SelectedSectionPanel.Controls)
        {
            usercontrol.RemoveSection -= RemoveSection;
            usercontrol.Dispose();
        }
        SelectedSectionPanel.Controls.Clear();

        foreach (SectionModel section in SelectedSections)
        {
            SectionUserControl sectionUserControl = new();
            sectionUserControl.SectionModel = section;
            sectionUserControl.RemoveSection += RemoveSection;
            sectionUserControl.Dock = DockStyle.Top;
            SelectedSectionPanel.Controls.Add(sectionUserControl);
        }
    }

    private void RemoveSection(object sender, EventArgs e)
    {
        SectionModel = (sender as SectionUserControl)?.SectionModel!;
            SelectedSectionPanel.Controls.Remove(sender as SectionUserControl);
            SelectedSections.Remove(SectionModel);
    }

    private void RemoveCheckedStudentsFromSelectedStudentsButton_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in SelectedStudentsListView.CheckedItems)
        {
            var student = item.Tag as StudentModel;
            SelectedStudents.Remove(student!);
        }
        LoadSelectedStudents();
    }

    private void TeachersListView_ItemActivate(object sender, EventArgs e)
    {
        var teacher = TeachersListView.SelectedItems[0].Tag as TeacherModel;
        SelectedTeacherTextBox.Text = teacher?.FullName;
        SelectedTeacherTextBox.Tag = teacher;
    }

    private void SearchTeacherTextBox_TextChanged(object sender, EventArgs e)
    {
        ReloadTeachersInListView(Teachers.Where(u => u.TeacherId.Contains(SearchTeacherTextBox.Text) || u.FullName.Contains(SearchTeacherTextBox.Text)).ToList());
    }

    private void CreateCourseButton_Click(object sender, EventArgs e)
    {
        if (SelectedTeacherTextBox.Tag is null)
        {
            MessageBox.Show("Please Select Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (SelectedSections.Count < 1)
        {
            MessageBox.Show("Please Create at least 1 section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }       
        
        CourseModel = new()
        {
            Name = CourseNameTextBox.Text,
            MidTermExam = MidTermDateTimePicker.Checked ? MidTermDateTimePicker.Value : null,
            FinalExam = MidTermDateTimePicker.Checked ? MidTermDateTimePicker.Value : null,
            Students = SelectedStudents,
            Sections = SelectedSections,
            TeacherId = (SelectedTeacherTextBox.Tag as TeacherModel).Id,
            CourseStartDate = CourseStartDate.Value,
            NumberOfSections = (int)NumberOfSectionNumericUpDown.Value
            //Teacher = SelectedTeacherTextBox.Tag as TeacherModel
        };

        CourseSaveEdit?.Invoke(this, EventArgs.Empty);

        if (IsSucess)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
        else
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    #endregion

}
