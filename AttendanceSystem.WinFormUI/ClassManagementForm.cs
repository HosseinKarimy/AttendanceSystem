using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Models.ViewModels;
using AttendanceSystem.Presenter.IPresenter;
using System.Text;

namespace AttendanceSystem.WinFormUI;

public partial class ClassManagementForm : Form, IClassManagementView
{

    public ActionType ActionType { get; set; }
    public bool IsSucess { get; set; }
    public string Message { get; set; }

    public ClassManagementForm()
    {
        InitializeComponent();
    }

    private void ClassManagementForm_Load(object sender, EventArgs e)
    {
        InitializeStudentsTabPage();
        InitializeCourseTabPage();
    }

    #region StudentsTabPage
    public List<StudentInfoModel> Students { get; set; }
    public List<StudentInfoModel> SelectedStudents { get; set; } = new();
    public SearchStudentModel SearchStudentModel { get; set; }
    public List<MajorModel> Majors { get; set; }
    public List<DegreeModel> Degrees { get; set; }

    public event EventHandler LoadStudents;
    public event EventHandler SearchStudents;
    public event EventHandler LoadDegreesAndMajors;

    private void InitializeStudentsTabPage()
    {
        SearchFullNameStudentTextBox.TextChanged += delegate {
            PreparingSearch();
            SearchStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        MajorComboBox.SelectedIndexChanged += delegate {
            PreparingSearch();
            SearchStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        DegreeComboBox.SelectedIndexChanged += delegate {
            PreparingSearch();
            SearchStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        StudentIDCheckBox.CheckedChanged += delegate {
            PreparingSearch();
            SearchStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
        StudentIDNumric.ValueChanged += delegate {
            PreparingSearch();
            SearchStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        };
    }

    //Events

    private void StudentSectionTabPage_Enter(object sender, EventArgs e)
    {
        ReloadStudentsForm();
    }

    private void ReloadStudentsForm()
    {
        LoadStudents?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        {
            ReloadStudentsInListView(Students);
            ReloadSelectedStudents();
        } else
            MessageBox.Show(Message);

        LoadDegreesAndMajors?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        {
            LoadMajorsInComboBox(Majors);
            LoadDegreesInComboBox(Degrees);
        } else
            MessageBox.Show(Message);
    }

    private void LoadMajorsInComboBox(List<MajorModel> majors)
    {
        List<MajorModel> temp = new() { new MajorModel(0, "None") };
        temp.AddRange(majors);
        MajorComboBox.DataSource = temp;
        MajorComboBox.DisplayMember = "Name";
        MajorComboBox.ValueMember = "Name";
    }

    private void LoadDegreesInComboBox(List<DegreeModel> degrees)
    {
        List<DegreeModel> temp = new() { new DegreeModel(0, "None") };
        temp.AddRange(degrees);
        DegreeComboBox.DataSource = temp;
        DegreeComboBox.DisplayMember = "Name";
        DegreeComboBox.ValueMember = "Name";
    }

    private void StudentIDCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (StudentIDCheckBox.Checked)
        {
            StudentIDNumric.Enabled = true;
        } else
        {
            StudentIDNumric.Enabled = false;
        }
    }

    private void AddStudentsButton_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in AllStudentsListView.CheckedItems)
        {
            SelectedStudents.Add((item.Tag as StudentInfoModel)!);
        }
        ReloadStudentsInListView(Students);
        ReloadSelectedStudents();
    }

    private void RemoveCheckedStudentsFromSelectedStudentsButton_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in SelectedStudentsListView.CheckedItems)
        {
            var student = item.Tag as StudentInfoModel;
            SelectedStudents.Remove(student!);
        }
        ReloadStudentsInListView(Students);
        ReloadSelectedStudents();
    }

    //Methods

    private void ReloadStudentsInListView(List<StudentInfoModel> students)
    {
        AllStudentsListView.Clear();

        AllStudentsListView.View = View.Details;
        AllStudentsListView.SetHeaders(new string[] { "StudentId", "FullName", "Major", "Degree" });

        foreach (var student in students)
        {
            if (SelectedStudents.Any(u => u.StudentID == student.StudentID))
                continue;
            var item = new ListViewItem(new String[] { student.StudentID.ToString(), student.FullName, student.MajorName, student.DegreeName })
            {
                Tag = student
            };
            AllStudentsListView.Items.Add(item);
        }
        AllStudentsListView.SetSize();
    }

    private void ReloadSelectedStudents()
    {
        SelectedStudentsListView.Clear();

        SelectedStudentsListView.View = View.Details;
        SelectedStudentsListView.SetHeaders(new string[] { "StudentId", "FullName", "Major", "Degree" });

        foreach (var student in SelectedStudents)
        {
            var item = new ListViewItem(new String[] { student.StudentID.ToString(), student.FullName, student.MajorName, student.DegreeName })
            {
                Tag = student
            };
            SelectedStudentsListView.Items.Add(item);
        }
        SelectedStudentsListView.SetSize();
    }

    private void PreparingSearch()
    {
        SearchStudentModel = new(
            string.IsNullOrEmpty(SearchFullNameStudentTextBox.Text) ? null : SearchFullNameStudentTextBox.Text,
            (string)DegreeComboBox.SelectedValue == "None" ? null : (string)DegreeComboBox.SelectedValue,
            (string)MajorComboBox.SelectedValue == "None" ? null : (string)MajorComboBox.SelectedValue,
            StudentIDCheckBox.Checked == false ? null : Convert.ToInt32(StudentIDNumric.Value));
    }

    #endregion


    #region CourseTabPage

    //members
    public TermCourseModel TermCourse { get; set; }
    public List<CourseModel> Courses { get; set; }
    public List<TermModel> Terms { get; set; }
    public List<TeacherModel> Teachers { get; set; }
    public List<SectionPerWeekModel> SectionsPerWeek { get; set; } = new();

    public event EventHandler CourseSaveEdit;
    public event EventHandler LoadTeachersAndCoursesAndTerms;

    private void InitializeCourseTabPage()
    {
        DayOfWeekComboBox.DataSource = Enum.GetValues(typeof(DayOfWeek));

        ClassDurationTimePicker.CustomFormat = "hh:mm";

        RemoveFromSelectedStudentsToolTip.SetToolTip(this.RemoveCheckedStudentsFromSelectedStudentsButton, "Remove Checked Students From Course");
    }

    //events
    private void CreateCourseTabPage_Enter(object sender, EventArgs e)
    {
        LoadCourseTabPageComponentsContext();
    }

    private void LoadCourseTabPageComponentsContext()
    {
        LoadSelectedSections();
        LoadTeachersAndCoursesAndTerms?.Invoke(this, EventArgs.Empty);
        LoadCoursesInComboBox();
        LoadTermsInComboBox();
        ReloadTeachersInListView(Teachers);
    }

    private void LoadTermsInComboBox()
    {
        List<TermModel> temp = new() { new TermModel(0, DateTime.Now) };
        temp.AddRange(Terms);
        SelectTermComboBox.DataSource = temp;
        SelectTermComboBox.DisplayMember = "TermID";
        SelectTermComboBox.ValueMember = "TermID";
    }

    private void LoadCoursesInComboBox()
    {
        List<CourseModel> temp = new() { new CourseModel(0, "None") };
        temp.AddRange(Courses);
        SelectCourseComboBox.DataSource = temp;
        SelectCourseComboBox.DisplayMember = "Name";
        SelectCourseComboBox.ValueMember = "CourseID";
    }

    private void TeachersListView_ItemActivate(object sender, EventArgs e)
    {
        var teacher = TeachersListView.SelectedItems[0].Tag as TeacherModel;
        SelectedTeacherTextBox.Text = $"{teacher?.FirstName} {teacher?.LastName}";
        SelectedTeacherTextBox.Tag = teacher;
    }

    private void SearchTeacherTextBox_TextChanged(object sender, EventArgs e)
    {
        ReloadTeachersInListView(Teachers.Where(u => u.TeacherID.ToString().Contains(SearchTeacherTextBox.Text) || u.FirstName.Contains(SearchTeacherTextBox.Text) || u.LastName.Contains(SearchTeacherTextBox.Text)).ToList());
    }

    private void CreateCourseButton_Click(object sender, EventArgs e)
    {
        if (CreateCourseInputValidation() is false)
            return;

        TermCourse = new(
            0,
            MidTermDateTimePicker.Checked ? MidTermDateTimePicker.Value : null,
            MidTermDateTimePicker.Checked ? MidTermDateTimePicker.Value : null,
            (SelectCourseComboBox.SelectedItem as CourseModel)!.CourseID,
            (SelectTermComboBox.SelectedItem as TermModel)!.TermID,
            (SelectedTeacherTextBox.Tag as TeacherModel)!.TeacherID
        );

        Students=SelectedStudents.ToList();
        CourseSaveEdit?.Invoke(this, EventArgs.Empty);

        if (IsSucess)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        } else
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private bool CreateCourseInputValidation()
    {
        var errors = new StringBuilder();
        bool flag = true;
        if (SelectedTeacherTextBox.Tag is null)
        {
            errors.AppendLine("Please Select Teacher");
            flag = false;
        }
        if (SectionsPerWeek.Count < 1)
        {
            errors.AppendLine("Please Create at least 1 section");
            flag = false;
        }
        if ((SelectCourseComboBox.SelectedItem as CourseModel)!.CourseID == 0)
        {
            errors.AppendLine("Please Select Course");
            flag = false;
        }
        if ((SelectTermComboBox.SelectedItem as TermModel)!.TermID == 0)
        {
            errors.AppendLine("Please Select Term");
            flag = false;
        }
        if (SelectedStudents.Count < 1)
        {
            errors.AppendLine("Please Select Student");
            flag = false;
        }

        if (flag is false)
            MessageBox.Show(errors.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return flag;
    }

    private void AddSectionButton_Click(object sender, EventArgs e)
    {
        var duration = new TimeSpan(ClassDurationTimePicker.Value.Hour % 12, ClassDurationTimePicker.Value.Minute, ClassDurationTimePicker.Value.Second);
        var time = new TimeOnly(SectionTimePicker.Value.Hour, SectionTimePicker.Value.Minute, SectionTimePicker.Value.Second);

        SectionsPerWeek.Add(new(time, duration, (DayOfWeek)DayOfWeekComboBox.SelectedItem));
        LoadSelectedSections();
    }

    private void SelectStudentsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        tabControl1.SelectedTab = tabControl1.TabPages["StudentTabPage"];
    }

    //methods


    private void ReloadTeachersInListView(List<TeacherModel> teachers)
    {
        TeachersListView.Clear();
        TeachersListView.View = View.Details;
        TeachersListView.SetHeaders(new string[] { "TeacherId", "Name" });

        foreach (var teacher in teachers)
        {
            var item = new ListViewItem(new String[] { teacher.TeacherID.ToString(), $"{teacher.FirstName} {teacher.LastName}" })
            {
                Tag = teacher
            };
            TeachersListView.Items.Add(item);
        }
        TeachersListView.SetSize();
    }

    private void LoadSelectedSections()
    {
        SelectedSectionPanel.Controls.Clear();

        foreach (var section in SectionsPerWeek)
        {
            SectionUserControl sectionUserControl = new()
            {
                SectionPerWeek = section
            };
            sectionUserControl.RemoveSection += (sender, e) =>
            {
                var sectionPerWeek = (sender as SectionUserControl)?.SectionPerWeek!;
                SelectedSectionPanel.Controls.Remove(sender as SectionUserControl);
                SectionsPerWeek.Remove(sectionPerWeek);
                (sender as Form)?.Dispose();
            };
            sectionUserControl.Dock = DockStyle.Top;
            SelectedSectionPanel.Controls.Add(sectionUserControl);
        }
    }

    #endregion


}
