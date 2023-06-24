using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Enums;
using AttendanceSystem.Presenter.IPresenter;
using System.Collections.Generic;

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
            LoadMajorsAndMajorsInComboBox();
        }

        public ActionType ActionType { get; set; }
        public bool IsSucess { get; set; }
        public string Message { get; set; }


        private void LoadDegreesInComboBox()
        {
            LoadMajorAndDegree?.Invoke(this, EventArgs.Empty);
            StudentMajorComboBox.DataSource = Majors;
            StudentGradeComboBox.DataSource = Degrees;
        }



        #region StudentsTabPage

        public StudentModel StudentModel { get; set; } 
        public List<StudentModel> Students { get; set; } = new();
        public List<StudentModel> SearchedStudents { get; set; } = new();
        public List<MajorModel> Majors { get; set; }
        public List<DegreeModel> Degrees { get; set; }

        public event EventHandler StudentDelete;
        public event EventHandler StudentSaveEdit;
        public event EventHandler LoadStudents;
        public event EventHandler LoadMajorAndDegree;

        //Events        

        private void StudentCreateSaveButton_Click(object sender, EventArgs e)
        {
            if (ActionType == ActionType.Create)
            {
                StudentModel = new()
                {
                    FirstName = StudentFirstNameTextBox.Text,
                    LastName = StudentLastNameTextBox.Text,
                    FatherName = StudentFatherNameTextBox.Text,
                    StudentId = StudentIdTextBox.Text,
                    BirthDate = StudentBODDateTimePicker.Value,
                    Grade = (Grade)StudentGradeComboBox.SelectedItem,
                    Major = (Major)StudentMajorComboBox.SelectedItem,
                    EntryYear = (int)StudentEntryYearNumericUpDown.Value
                };
            } else if (ActionType == ActionType.Update)
            {
                StudentModel.FirstName = StudentFirstNameTextBox.Text;
                StudentModel.LastName = StudentLastNameTextBox.Text;
                StudentModel.FatherName = StudentFatherNameTextBox.Text;
                StudentModel.StudentId = StudentIdTextBox.Text;
                StudentModel.BirthDate = StudentBODDateTimePicker.Value;
                StudentModel.Grade = (Grade)StudentGradeComboBox.SelectedItem;
                StudentModel.Major = (Major)StudentMajorComboBox.SelectedItem;
                StudentModel.EntryYear = (int)StudentEntryYearNumericUpDown.Value;
            }
            StudentSaveEdit?.Invoke(sender, e);
            MessageBox.Show(Message);
            if (IsSucess)
            {
                LoadStudentsInListView();
                ClearStudentForm();
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
            var result = MessageBox.Show($"Are you sure for delete {StudentModel.FullName} ?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                StudentDelete?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                if (IsSucess)
                {
                    LoadStudentsInListView();
                }
                ClearStudentForm();
            }
        }

        private void StudentSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var SearchString = StudentSearchTextBox.Text;
            SearchedStudents = Students.Where(u => u.FullName.Contains(SearchString) || u.StudentId.Contains(SearchString)).ToList();
            ReloadStudentsInListView(SearchedStudents);
        }

        private void ResetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearStudentForm();
        }

        //methods

        private void LoadStudentsInListView()
        {
            LoadStudents?.Invoke(this, EventArgs.Empty);
            ReloadStudentsInListView(Students);
        }

        private void ReloadStudentsInListView(List<StudentModel> students)
        {
            StudentsListView.Columns.Clear();
            StudentsListView.Items.Clear();

            StudentsListView.View = View.Details;
            StudentsListView.Columns.Add("StudentId");
            StudentsListView.Columns.Add("Name");

            foreach (var student in students)
            {
                var item = new ListViewItem(new String[] { student.StudentId, student.FullName });
                item.Tag = student;
                StudentsListView.Items.Add(item);
            }
            StudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            StudentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ClearStudentForm()
        {
            StudentFirstNameTextBox.Text = String.Empty;
            StudentLastNameTextBox.Text = String.Empty;
            StudentFatherNameTextBox.Text = String.Empty;
            StudentIdTextBox.Text = String.Empty;
            StudentSearchTextBox.Text = String.Empty;
            StudentBODDateTimePicker.ResetText();
            StudentGradeComboBox.SelectedItem = Grade.none;
            StudentMajorComboBox.SelectedItem = Major.none;
            //StudentEntryYearNumericUpDown.Value = StudentEntryYearNumericUpDown.Minimum;

            ActionType = ActionType.Create;
            StudentCreateSaveButton.Text = "Create";
        }

        private void LoadSelectedStudent(StudentModel selectedStudent)
        {
            StudentFirstNameTextBox.Text = selectedStudent.FirstName;
            StudentLastNameTextBox.Text = selectedStudent.LastName;
            StudentFatherNameTextBox.Text = selectedStudent.FatherName;
            StudentIdTextBox.Text = selectedStudent.StudentId;
            StudentBODDateTimePicker.Value = selectedStudent.BirthDate ?? DateTime.Now;
            StudentGradeComboBox.SelectedItem = selectedStudent.Grade;
            StudentMajorComboBox.SelectedItem = selectedStudent.Major;
        }
        #endregion

        #region TeachersTabPage
        public TeacherModel TeacherModel { get; set; }
        public List<TeacherModel> Teachers { get; set; } = new();
        public List<TeacherModel> SearchedTeachers { get; set; } = new();


        public event EventHandler TeacherSaveEdit;
        public event EventHandler TeacherDelete;
        public event EventHandler LoadTeachers;



        //events


        private void TeachersListView_ItemActivate(object sender, EventArgs e)
        {
            TeacherModel = (TeachersListView.SelectedItems[0].Tag as TeacherModel)!;
            LoadSelectedTeacher(TeacherModel);
            ActionType = ActionType.Update;
            TeacherCreateSaveButton.Text = "Edit";
        }

        private void TeacherCreateSaveButton_Click(object sender, EventArgs e)
        {
            if (ActionType == ActionType.Create)
            {
                TeacherModel = new()
                {
                    FirstName = TeacherFirstNameTextBox.Text,
                    LastName = TeacherLastNameTextBox.Text,
                    FatherName = TeacherFatherNameTextBox.Text,
                    TeacherId = TeacherIdTextBox.Text,
                    BirthDate = TeacherBODDateTimePicker.Value
                };
            } else if (ActionType == ActionType.Update)
            {
                TeacherModel.FirstName = TeacherFirstNameTextBox.Text;
                TeacherModel.LastName = TeacherLastNameTextBox.Text;
                TeacherModel.FatherName = TeacherFatherNameTextBox.Text;
                TeacherModel.TeacherId = TeacherIdTextBox.Text;
                TeacherModel.BirthDate = TeacherBODDateTimePicker.Value;
            }

            TeacherSaveEdit?.Invoke(sender, e);
            MessageBox.Show(Message);
            if (IsSucess)
            {
                LoadTeachersInListView();
                ClearTeacherForm();
            }
        }

        private void TeacherDeleteButton_Click(object sender, EventArgs e)
        {
            TeacherModel = (TeachersListView.SelectedItems[0].Tag as TeacherModel)!;
            ActionType = ActionType.Delete;
            var result = MessageBox.Show($"Are you sure for delete {TeacherModel.FullName} ?", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                TeacherDelete?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                if (IsSucess)
                {
                    LoadTeachersInListView();
                }
                ClearTeacherForm();
            }
        }

        private void TeacherSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var SearchString = TeacherSearchTextBox.Text;
            SearchedTeachers = Teachers.Where(u => u.FullName.Contains(SearchString) || u.TeacherId.Contains(SearchString)).ToList();
            ReloadTeachersInListView(SearchedTeachers);
        }

        private void TeacherFormResetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearTeacherForm();
        }

        //Methods
        private void LoadTeachersInListView()
        {
            LoadTeachers?.Invoke(this, EventArgs.Empty);
            ReloadTeachersInListView(Teachers);
        }

        private void ReloadTeachersInListView(List<TeacherModel> Teachers)
        {
            TeachersListView.Columns.Clear();
            TeachersListView.Items.Clear();

            TeachersListView.View = View.Details;
            TeachersListView.Columns.Add("TeacherId");
            TeachersListView.Columns.Add("Name");

            foreach (var Teacher in Teachers)
            {
                var item = new ListViewItem(new String[] { Teacher.TeacherId, Teacher.FullName });
                item.Tag = Teacher;
                TeachersListView.Items.Add(item);
            }
            TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            TeachersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadSelectedTeacher(TeacherModel selectedTeacher)
        {
            TeacherFirstNameTextBox.Text = selectedTeacher.FirstName;
            TeacherLastNameTextBox.Text = selectedTeacher.LastName;
            TeacherFatherNameTextBox.Text = selectedTeacher.FatherName;
            TeacherIdTextBox.Text = selectedTeacher.TeacherId;
            TeacherBODDateTimePicker.Value = selectedTeacher.BirthDate ?? DateTime.Now;
        }

        private void ClearTeacherForm()
        {
            TeacherFirstNameTextBox.Text = String.Empty;
            TeacherLastNameTextBox.Text = String.Empty;
            TeacherFatherNameTextBox.Text = String.Empty;
            TeacherIdTextBox.Text = String.Empty;
            TeacherSearchTextBox.Text = String.Empty;
            TeacherBODDateTimePicker.ResetText();

            ActionType = ActionType.Create;
            TeacherCreateSaveButton.Text = "Create";
        }

        #endregion


    }
}

