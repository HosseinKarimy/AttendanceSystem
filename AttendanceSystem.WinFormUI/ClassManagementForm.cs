using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem.WinFormUI
{
    public partial class ClassManagementForm : Form
    {
        public ClassManagementForm()
        {
            InitializeComponent();
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {
            DayOfWeekComboBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
            GradeComboBox.DataSource = Enum.GetValues(typeof(Grade));
            MajorComboBox.DataSource = Enum.GetValues(typeof(Major));
            const int shamsi_miladi_diff = 621;
            EntryYearNumric.Minimum = DateTime.Now.AddYears(-8).Year - shamsi_miladi_diff;
            EntryYearNumric.Maximum = DateTime.Now.Year - shamsi_miladi_diff;
            ClassDurationTimePicker.CustomFormat = "mm:hh";

            for (int i = 0; i < 2; i++)
            {
                var newUC = new SectionUserControl();
                newUC.Dock = DockStyle.Top;
                SectionPanel.Controls.Add(newUC);
            }

        }
    }
}
