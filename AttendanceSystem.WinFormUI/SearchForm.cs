using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Ado_SqlServer.Views;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;
using System.Data;

namespace AttendanceSystem.WinFormUI;

public partial class SearchForm : Form, ISearchView
{
    public SearchForm()
    {
        InitializeComponent();
    }

    public List<TeacherModel> AllTeachers { get; set; }
    public List<TermCourseDetailsModel> TermCoursesOfTeacher { get; set; }
    public List<SectionModel> Sections { get; set; }
    public List<StudentStatusModel> StudentStatuses { get; set; }

    public event EventHandler LoadTeachers;

    private void SearchForm_Enter(object sender, EventArgs e)
    {
        LoadTeachers?.Invoke(this, EventArgs.Empty);
        LoadTreeView();
    }

    private void LoadTreeView()
    {
        FilterTreeView.Nodes.Clear();
        AddTeacherTree();
       // AddStudentTree();
    }

    private void AddTeacherTree()
    {
        var Root = new TreeNode("Teachers");
        foreach (TeacherModel teacher in AllTeachers)
        {
            var TeacherRoot = new TreeNode(teacher.FullName);            
            Root.Nodes.Add(TeacherRoot);
        }
        FilterTreeView.Nodes.Add(Root);
    }

    private void AddStudentTree()
    {
        //var Root = new TreeNode("Students");

        //var MajorsRoot = new TreeNode("Majors");
        //foreach (Major major in AllStudents.GroupBy(u => u.Major).Select(u => u.Key).ToList())
        //{
        //    var MajorRoot = new TreeNode(major.ToString());
        //    foreach (StudentModel student in AllStudents.Where(u => u.Major == major))
        //    {
        //        var studentRoot = new TreeNode(student.FullName);
        //        foreach (CourseModel course in student.Courses)
        //        {
        //            var CourseRoot = new TreeNode(course.Name);
        //            foreach (SectionModel section in course.Sections)
        //            {
        //                var SectionNode = new TreeNode(section.SectionDetails);
        //                SectionNode.Tag = section;
        //                CourseRoot.Nodes.Add(SectionNode);
        //            }
        //            studentRoot.Nodes.Add(CourseRoot);
        //        }
        //        MajorRoot.Nodes.Add(studentRoot);
        //    }
        //    MajorsRoot.Nodes.Add(MajorRoot);
        //}
        //Root.Nodes.Add(MajorsRoot);


        //var EntryYearRoot = new TreeNode("Entry Year");
        //foreach (int year in AllStudents.GroupBy(u => u.EntryYear).Select(u => u.Key).ToList())
        //{
        //    var YearRoot = new TreeNode(year.ToString());
        //    foreach (StudentModel student in AllStudents.Where(u => u.EntryYear == year))
        //    {
        //        var studentRoot = new TreeNode(student.FullName);
        //        foreach (CourseModel course in student.Courses)
        //        {
        //            var CourseRoot = new TreeNode(course.Name);
        //            foreach (SectionModel section in course.Sections)
        //            {
        //                var SectionNode = new TreeNode(section.SectionDetails);
        //                SectionNode.Tag = section;
        //                CourseRoot.Nodes.Add(SectionNode);
        //            }
        //            studentRoot.Nodes.Add(CourseRoot);
        //        }
        //        YearRoot.Nodes.Add(studentRoot);
        //    }
        //    EntryYearRoot.Nodes.Add(YearRoot);
        //}
        //Root.Nodes.Add(EntryYearRoot);


        //FilterTreeView.Nodes.Add(Root);
    }

    private void LoadSectionInListView(SectionModel? sectionModel)
    {
        //ResultPanel.Controls.Clear();
        //if (AllRadioButton.Checked)
        //{
        //    foreach (StudentStatusModel studentStatus in sectionModel?.StudentsStatus)
        //    {
        //        var newSSUC = new StudentStatusUserControl();
        //        newSSUC.StudentStatusModel = studentStatus;
        //        newSSUC.IsReadOnly = true;
        //        newSSUC.Dock = DockStyle.Top;
        //        ResultPanel.Controls.Add(newSSUC);
        //    }
        //}
        //else
        //{
        //    foreach (StudentStatusModel studentStatus in sectionModel?.StudentsStatus!.Where(u => u.IsPresent == AttendeesRadioButton.Checked))
        //    {
        //        var newSSUC = new StudentStatusUserControl();
        //        newSSUC.StudentStatusModel = studentStatus;
        //        newSSUC.IsReadOnly = true;
        //        newSSUC.Dock = DockStyle.Top;
        //        ResultPanel.Controls.Add(newSSUC);
        //    }
        //}
    }

    private void FilterTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (FilterTreeView.SelectedNode?.Tag is not null && FilterTreeView.SelectedNode.Tag is SectionModel)
        {
            LoadSectionInListView(FilterTreeView.SelectedNode.Tag as SectionModel);
        }
    }

    private void AllRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (FilterTreeView.SelectedNode?.Tag is not null && FilterTreeView.SelectedNode.Tag is SectionModel)
        {
            LoadSectionInListView(FilterTreeView.SelectedNode.Tag as SectionModel);
        }
    }
}
