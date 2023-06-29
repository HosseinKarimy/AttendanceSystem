using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Presenter.IInteraction;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AttendanceSystem.WinFormUI;

public partial class AttendanceListForm : Form, IAttendanceListView, IRole
{
    public Role Role { get; init; } = Role.Admin;
    public UsersModel CurrentUser { get; init; }
    public List<TeacherModel> Teachers { get; set; } = new();
    public TeacherModel SelectedTeacher { get; set; }
    public List<TermCourseDetailsModel> TermCoursesOfTeacher { get; set; } = new();
    public TermCourseDetailsModel SelectedTermCourse { get; set; }
    public List<SectionModel> Sections { get; set; } = new();
    public SectionModel SelectedSection { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; } = new();
    public bool IsSucess { get; set; }
    public string Message { get; set; }
    public StudentFullInfoModel StudentFullInfo { get; set; }

    public AttendanceListForm()
    {
        InitializeComponent();
    }

    public event EventHandler LoadTeachers;
    public event EventHandler LoadTermCoursesOfTeacher;
    public event EventHandler LoadSectionsOfTermCourse;
    public event EventHandler LoadStudentsStatusOfSection;
    public event EventHandler UpdateSection;
    public event EventHandler LoadStudentsFullInfo;

    private void AttendanceListForm_Load(object sender, EventArgs e)
    {
        LoadForm();
    }

    private void LoadForm()
    {
        //Teachers.Clear();
        TeacherComboBox.Items.Clear();
        CourseComboBox.Items.Clear();
        SectionComboBox.Items.Clear();
        ResultPanel.Controls.Clear();
        StudentStatuses.Clear();
        if (Role == Role.Admin)
        {
            LoadTeachers?.Invoke(this, EventArgs.Empty);
        } else if (Role == Role.Teacher)
        {
            //Todo - Form For Teacher Role
        }
        if (IsSucess)
        {
            LoadTeachersInTeacherComboBox(Teachers);
        } else
        {
            MessageBox.Show(Message);
        }
    }

    private void LoadTeachersInTeacherComboBox(List<TeacherModel> teachers)
    {
        foreach (TeacherModel teacher in teachers)
        {
            TeacherComboBox.Items.Add(teacher);
            TeacherComboBox.DisplayMember = "FullName";
        }
    }

    private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadTeachersCourses((TeacherComboBox.SelectedItem as TeacherModel)!);
    }

    private void LoadTeachersCourses(TeacherModel selected)
    {
        CourseComboBox.Items.Clear();
        SectionComboBox.Items.Clear();
        ResultPanel.Controls.Clear();
        StudentStatuses.Clear();
        SelectedTeacher = selected;
        LoadTermCoursesOfTeacher?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        {
            LoadTermCoursesInComboBox(TermCoursesOfTeacher);
        } else
        {
            MessageBox.Show(Message);
        }
    }

    private void LoadTermCoursesInComboBox(List<TermCourseDetailsModel> termCoursesOfTeacher)
    {
        foreach (var termCourse in termCoursesOfTeacher)
        {
            CourseComboBox.Items.Add(termCourse);
            CourseComboBox.DisplayMember = "CourseInfo";
        }
    }

    private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        SectionComboBox.Items.Clear();
        ResultPanel.Controls.Clear();
        StudentStatuses.Clear();
        SelectedTermCourse = (CourseComboBox.SelectedItem as TermCourseDetailsModel)!;
        LoadSectionsOfTermCourse?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        {
            LoadSectionsOfCourse(Sections);
        } else
        {
            MessageBox.Show(Message);
        }
    }

    private void LoadSectionsOfCourse(List<SectionModel> sections)
    {
        foreach (SectionModel section in sections)
        {
            SectionComboBox.Items.Add(section);
            SectionComboBox.DisplayMember = "SectionDetails";
        }
    }

    private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectedSection = (SectionComboBox.SelectedItem as SectionModel)!;
        LoadStudentsStatusOfSection?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        {
            LoadStudentsStatusOfSelectedSection(StudentStatuses);
        } else
        {
            MessageBox.Show(Message);
        }
    }

    private void LoadStudentsStatusOfSelectedSection(List<StudentStatusModel> studentStatuses)
    {
        AllStudentsCountLabel.Text = studentStatuses.Count.ToString();
        AbsenteesStudentsCountLabel.Text = "0";
        AttendeesStudentsCountLabel.Text = "0";
        ResultPanel.Controls.Clear();
        foreach (StudentStatusModel studentStatus in studentStatuses)
        {
            LoadStudentsFullInfo?.Invoke(studentStatus.StudentID, EventArgs.Empty);
            var newSSUC = new StudentStatusUserControl
            {
                StudentFullInfoModel = StudentFullInfo,
                StudentStatusModel = studentStatus,
                Dock = DockStyle.Top
            };
            newSSUC.ChangePresentStatus += NewSSUC_ChangePresentStatus;
            ResultPanel.Controls.Add(newSSUC);
        }
    }

    private void NewSSUC_ChangePresentStatus(object? sender, EventArgs e)
    {
        AbsenteesStudentsCountLabel.Text = StudentStatuses.Where(u => u.IsPresent is false).Count().ToString();
        AttendeesStudentsCountLabel.Text = StudentStatuses.Where(u => u.IsPresent is true).Count().ToString();
    }

    private void SaveListButton_Click(object sender, EventArgs e)
    {
        UpdateSection?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
    }
}
