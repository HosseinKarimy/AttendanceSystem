using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IPresenter;
using Models.Enums;
using Models.Models;

namespace AttendanceSystem.WinFormUI
{
    public partial class UserManagement : Form, IUserManagementView
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void StudentsManagement_Load(object sender, EventArgs e)
        {
            LoadTeachersInListView();
            LoadStudentsInListView();
            StudentGradeComboBox.DataSource = Enum.GetValues(typeof(Grade));
            StudentMajorComboBox.DataSource = Enum.GetValues(typeof(Major));
            const int shamsi_miladi_diff = 621;
            StudentEntryYearNumericUpDown.Minimum = DateTime.Now.AddYears(-8).Year - shamsi_miladi_diff;
            StudentEntryYearNumericUpDown.Maximum = DateTime.Now.Year - shamsi_miladi_diff;
        }

        public ActionType ActionType { get; set; }
        public bool IsSucess { get; set; }
        public string Message { get; set; }       
       

        #region StudentsTabPage

        public StudentModel StudentModel { get; set; } = new();
        public List<StudentModel> Students { get; set; } = new();

        public event EventHandler StudentDelete;
        public event EventHandler StudentSaveEdit;       
        public event EventHandler LoadStudents;

        //Events        

        private void StudentCreateSaveButton_Click(object sender, EventArgs e)
        {
            StudentModel.FirstName = StudentFirstNameTextBox.Text;
            StudentModel.LastName = StudentLastNameTextBox.Text;
            StudentModel.FatherName = StudentFatherNameTextBox.Text;
            StudentModel.StudnetId = StudentIdTextBox.Text;
            StudentModel.BirthDate = StudentBODDateTimePicker.Value;
            StudentModel.Grade = (Grade)StudentGradeComboBox.SelectedItem;
            StudentModel.Major = (Major)StudentMajorComboBox.SelectedItem;
            StudentModel.EntryYear = (int)StudentEntryYearNumericUpDown.Value;

            StudentSaveEdit?.Invoke(sender, e);
            MessageBox.Show(Message);
            if (IsSucess)
            {
                LoadStudentsInListView();
                ClearForm();
            }
        }

        private void StudentsListView_ItemActivate(object sender, EventArgs e)
        {
            StudentModel = (StudentsListView.SelectedItems[0].Tag as StudentModel)!;
            LoadSelectedStudent(StudentModel);
            ActionType = ActionType.Update;
            StudentCreateSaveButton.Text = "Edit";
        }

        private void StudentDeleteButton_Click(object sender, EventArgs e)
        {
            StudentModel = (StudentsListView.SelectedItems[0].Tag as StudentModel)!;
            ActionType = ActionType.Delete;
            var result = MessageBox.Show($"Are you sure for delete {StudentModel.FullName} ?","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                StudentDelete?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                if (IsSucess)
                {
                    LoadStudentsInListView();
                    ClearForm();
                }
            }            
        }

        private void ResetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearForm();
        }

        //methods
        private void LoadStudentsInListView()
        {
            LoadStudents?.Invoke(this, EventArgs.Empty);

            StudentsListView.Columns.Clear();
            StudentsListView.Items.Clear();

            StudentsListView.View = View.Details;
            StudentsListView.Columns.Add("StudentId");
            StudentsListView.Columns.Add("Name");

            foreach (var student in Students)
            {
                var item = new ListViewItem(new String[] { student.StudnetId, student.FullName });
                item.Tag = student;
                StudentsListView.Items.Add(item);
            }
            StudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            StudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ClearForm()
        {
            StudentFirstNameTextBox.Text = String.Empty;
            StudentLastNameTextBox.Text = String.Empty;
            StudentFatherNameTextBox.Text = String.Empty;
            StudentIdTextBox.Text = String.Empty;
            StudentBODDateTimePicker.ResetText();
            StudentGradeComboBox.SelectedItem = Grade.none;
            StudentMajorComboBox.SelectedItem = Major.none;
            //StudentEntryYearNumericUpDown.Value = StudentEntryYearNumericUpDown.Minimum;

            ActionType = ActionType.Create;
            StudentCreateSaveButton.Text = "Edit";
        }

        private void LoadSelectedStudent(StudentModel selectedStudent)
        {
            StudentFirstNameTextBox.Text = selectedStudent.FirstName;
            StudentLastNameTextBox.Text = selectedStudent.LastName;
            StudentFatherNameTextBox.Text = selectedStudent.FatherName;
            StudentIdTextBox.Text = selectedStudent.StudnetId;
            StudentBODDateTimePicker.Value = selectedStudent.BirthDate ?? DateTime.Now;
            StudentGradeComboBox.SelectedItem = selectedStudent.Grade;
            StudentMajorComboBox.SelectedItem = selectedStudent.Major;
            StudentEntryYearNumericUpDown.Value = selectedStudent.EntryYear;
        }
        #endregion

        #region TeachersTabPage
        public TeacherModel TeacherModel { get; set; } = new();
        public List<TeacherModel> Teachers { get; set; } = new();

        public event EventHandler TeacherSaveEdit;
        public event EventHandler TeacherDelete;
        public event EventHandler LoadTeachers;


        private void LoadTeachersInListView()
        {
            LoadTeachers?.Invoke(this, EventArgs.Empty);
            
            TeachersListView.Columns.Clear();
            TeachersListView.Items.Clear();

            TeachersListView.View = View.Details;
            TeachersListView.Columns.Add("StudentId");
            TeachersListView.Columns.Add("Name");

            foreach (var Teacher in Teachers)
            {
                var item = new ListViewItem(new String[] { Teacher.TeacherId, Teacher.FullName });
                item.Tag = Teacher;
                StudentsListView.Items.Add(item);
            }
            TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

    }
}

