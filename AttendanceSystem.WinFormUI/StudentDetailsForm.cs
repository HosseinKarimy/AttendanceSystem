using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using Microsoft.VisualBasic.Devices;
using System.Data;

namespace AttendanceSystem.WinFormUI;

public partial class StudentDetailsForm : Form, IStudentDetailsView
{
    public StudentDetailsForm()
    {
        InitializeComponent();
    }

    public StudentFullInfoModel StudentFullInfoModel { get; set; }
    public List<TermCourseDetailsModel> TermCoursesDetails { get; set; } = new();
    public bool IsSucess { get; set; }
    public string Message { get; set; }
    public List<StudentStatusInfoPerTermCourse> StudentStatusInfoPerTermCourse { get; set; } = new();

    public event EventHandler LoadTermCoursesOfStudent;
    public event EventHandler GetSSOfTermCourseForSpecificStudent;

    private void StudentDetailsForm_Load(object sender, EventArgs e)
    {

        this.Text = StudentFullInfoModel.StudentID.ToString(); ;

        NameTextBox.Text = StudentFullInfoModel?.FirstName;
        LastNameTextBox.Text = StudentFullInfoModel?.LastName;
        FatherNameTextBox.Text = StudentFullInfoModel?.FatherName;
        StudentIdTextBox.Text = StudentFullInfoModel?.StudentID.ToString();
        MajorTextBox.Text = StudentFullInfoModel?.MajorName;
        GradeTextBox.Text = StudentFullInfoModel?.DegreeName;
        BirthDateTextBox.Text = StudentFullInfoModel?.BirthDate?.ToShortDateString() ?? "N/A";

        LoadTermCoursesOfStudent?.Invoke(this, EventArgs.Empty);
        if (IsSucess)
        LoadTermCoursesInComboBox(TermCoursesDetails);
    }

    private void LoadTermCoursesInComboBox(List<TermCourseDetailsModel> termCoursesDetails)
    {
        CoursesComboBox.DisplayMember = "CourseInfo";
        foreach (var course in termCoursesDetails)
        {
            CoursesComboBox.Items.Add(course);
        }
    }

    private void CoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var course = CoursesComboBox.SelectedItem as TermCourseDetailsModel;
        CourseNameTextBox.Text = course?.CourseName;

        GetSSOfTermCourseForSpecificStudent?.Invoke(course?.TermCourseID, EventArgs.Empty);
        if (IsSucess)
        {
            LoadStatusInListView(StudentStatusInfoPerTermCourse);
        }                      
    }

    private void LoadStatusInListView(List<StudentStatusInfoPerTermCourse> studentStatusInfoPerTermCourse)
    {
        SectionsListView.Clear();
        SectionCountLabel.Text = studentStatusInfoPerTermCourse.Count.ToString();
        AbsentCountLabel.Text = studentStatusInfoPerTermCourse?.Where(u => u.IsPresent == false).Count().ToString();
        PresentCountLabel.Text = studentStatusInfoPerTermCourse?.Where(u => u.IsPresent == true).Count().ToString();

        SectionsListView.Clear();
        SectionsListView.View = View.Details;
        SectionsListView.SetHeaders(new string[] { "Section", "Date" , "Day" , "Status" });

        foreach (var SS in studentStatusInfoPerTermCourse)
        {
            SectionsListView.Items.Add(
                new ListViewItem(new String[]
                    { 
                        SS.SectionNumber.ToString() ?? "N/A",
                        SS.Date?.ToString() ?? "N/A",
                        SS.Date?.DayOfWeek.ToString() ?? "N/A" ,
                        SS.IsPresent is null ? "Unknown" : SS.IsPresent is true ? "Present" : "Absent"
                    }));            
        }
        SectionsListView.SetSize();
    }

}
