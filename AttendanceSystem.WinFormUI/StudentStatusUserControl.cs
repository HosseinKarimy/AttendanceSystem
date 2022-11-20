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
    public partial class StudentStatusUserControl : UserControl
    {
        public StudentStatusUserControl()
        {
            InitializeComponent();
        }

        private void DescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DescriptionCheckBox.Checked)
            {
                this.Height = 59;
            }
            else
            {
                this.Height = 32;
            }
        }

        private void PresentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PresentCheckBox.Checked)
            {
                MainPanel.BackColor = Color.LightGreen;
            }
            else
                MainPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF5859");
        }
    }
}
