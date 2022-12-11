﻿using AttendanceSystem.Models.Models;
using AttendanceSystem.Models.Search_Models;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using Models.Models;

namespace AttendanceSystem.WinFormUI;

public partial class AttendanceListForm : Form, IAttendanceListView
{
    public AttendanceListForm()
    {
        InitializeComponent();
    }

    public SearchStudentStatusesModel SearchSectionModel { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }
    public List<TeacherModel> Teachers { get; set; } = new();
    public SectionModel Section { get; set; } = new();
    public bool IsSucess { get; set; }
    public string Message { get; set; }

    public event EventHandler LoadTeachers;
    public event EventHandler UpdateSection;

    private void AttendanceListForm_Load(object sender, EventArgs e)
    {
        LoadTeachersInTeacherComboBox();
    }

    private void LoadTeachersInTeacherComboBox()
    {
        LoadTeachers?.Invoke(this, EventArgs.Empty);
        TeacherComboBox.Items.Clear();
        CourseComboBox.Items.Clear();
        SectionComboBox.Items.Clear();
        foreach (TeacherModel teacher in Teachers)
        {
            TeacherComboBox.Items.Add(teacher);
            TeacherComboBox.DisplayMember = "FullName";
        }
    }

    private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        TeacherModel selected = (TeacherComboBox.SelectedItem as TeacherModel)!;
        LoadTeachersCourseInCourseComboBox(selected);
    }

    private void LoadTeachersCourseInCourseComboBox(TeacherModel selected)
    {
        CourseComboBox.Items.Clear();
        SectionComboBox.Items.Clear();
        foreach (CourseModel course in selected.Courses)
        {
            CourseComboBox.Items.Add(course);
            CourseComboBox.DisplayMember = "Name";
        }
    }

    private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        CourseModel selectedCourse = (CourseComboBox.SelectedItem as CourseModel)!;
        LoadSectionsOfCourseInSectionComboBox(selectedCourse);
    }

    private void LoadSectionsOfCourseInSectionComboBox(CourseModel selectedCourse)
    {
        SectionComboBox.Items.Clear();
        foreach (SectionModel section in selectedCourse.Sections)
        {
            SectionComboBox.Items.Add(section);
            SectionComboBox.DisplayMember = "SectionDetails";
        }
    }

    private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Section = (SectionComboBox.SelectedItem as SectionModel)!;
        LoadStudentsStatusOfSelectedSection(Section);
    }

    private void LoadStudentsStatusOfSelectedSection(SectionModel selectedSection)
    {
        AllStudentsCountLabel.Text = selectedSection.StudentsStatus.Count.ToString();
        ResultPanel.Controls.Clear();
        foreach (StudentStatusModel studentStatus in selectedSection.StudentsStatus)
        {
            var newSSUC = new StudentStatusUserControl();
            newSSUC.StudentStatusModel = studentStatus;
            newSSUC.Dock = DockStyle.Top;
            newSSUC.ChangePresentStatus += NewSSUC_ChangePresentStatus;
            ResultPanel.Controls.Add(newSSUC);
        }
    }

    private void NewSSUC_ChangePresentStatus(object? sender, EventArgs e)
    {
        AbsenteesStudentsCountLabel.Text = Section.StudentsStatus.Where(u => u.IsPresent is false).Count().ToString();
        AttendeesStudentsCountLabel.Text = Section.StudentsStatus.Where(u => u.IsPresent is true).Count().ToString();
    }

    private void SaveListButton_Click(object sender, EventArgs e)
    {
        UpdateSection?.Invoke(this, EventArgs.Empty);
        MessageBox.Show(Message);
    }
}
