using AttendanceSystem.Models.Models;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using Models.Models;
using System.Data;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceSystem.WinFormUI;

public partial class StudentDetailsForm : Form, IStudentDetailsView
{
    public StudentDetailsForm()
    {
        InitializeComponent();
    }

    public StudentModel StudentModel { get; set; } = new();

    private void StudentDetailsForm_Load(object sender, EventArgs e)
    {
        this.Text = StudentModel.FullName;

        NameTextBox.Text = StudentModel?.FirstName;
        LastNameTextBox.Text = StudentModel?.LastName;
        FatherNameTextBox.Text = StudentModel?.FatherName;
        StudentIdTextBox.Text = StudentModel?.StudentId?.ToString();
        MajorTextBox.Text = StudentModel?.Major.ToString();
        GradeTextBox.Text = StudentModel?.Grade.ToString();

        CoursesComboBox.DisplayMember = "Name";
        foreach (CourseModel course in StudentModel?.Courses ?? new())
        {
            CoursesComboBox.Items.Add(course);
        }
    }

    private void CoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var course = CoursesComboBox.SelectedItem as CourseModel;
        CourseNameTextBox.Text = course?.Name;
        SectionCountLabel.Text = course?.Sections.Count().ToString();
        var statuses = course?.Sections.Select(u => u.StudentsStatus.First(p => p.StudentId == StudentModel.Id)).ToList();
        AbsentCountLabel.Text = statuses?.Where(u => u.IsPresent == false).Count().ToString();
        PresentCountLabel.Text = statuses?.Where(u => u.IsPresent == true).Count().ToString();

        LoadStatusInListView(course);
    }

    private void LoadStatusInListView(CourseModel? course)
    {
        SectionsListView.Clear();
        SectionsListView.View = View.Details;
        SectionsListView.Columns.Add("Section");
        SectionsListView.Columns.Add("Date");
        SectionsListView.Columns.Add("Day");
        SectionsListView.Columns.Add("Status");

        foreach (SectionModel section in course.Sections ?? new())
        {
            var isPresent = section.StudentsStatus.First(section => section.StudentId == StudentModel.Id).IsPresent;
            if (isPresent is not null)
                SectionsListView.Items.Add(new ListViewItem(new String[] { section.SectionNumber.ToString(), section.ClassDate.ToString(), section.Day.ToString(), (bool)isPresent ? "Present" : "Absent" }));
            else
                SectionsListView.Items.Add(new ListViewItem(new String[] { section.SectionNumber.ToString(), section.ClassDate.ToString(), section.Day.ToString(), "Unknown" }));
        }
        SectionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        SectionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

}
