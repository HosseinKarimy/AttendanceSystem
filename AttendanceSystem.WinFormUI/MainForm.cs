namespace AttendanceSystem.WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            var newForm = new SearchForm();
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void AttendanceListButton_Click(object sender, EventArgs e)
        {
            var newForm = new AttendanceListForm();
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void UserManagmentButton_Click(object sender, EventArgs e)
        {
            var newForm = new UserManagement();
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void ClassManagementButton_Click(object sender, EventArgs e)
        {
            var newForm = new ClassManagementForm();
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }
    }
}