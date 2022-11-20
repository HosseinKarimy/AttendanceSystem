using Models.Enums;

namespace AttendanceSystem.WinFormUI
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void StudentsManagement_Load(object sender, EventArgs e)
        {
            StudentGradeComboBox.DataSource = Enum.GetValues(typeof(Grade));
            StudentMajorComboBox.DataSource = Enum.GetValues(typeof(Major));
        }
    }
}
