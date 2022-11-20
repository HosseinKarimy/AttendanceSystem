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
    public partial class DisplayDataForm : Form
    {
        public DisplayDataForm()
        {
            InitializeComponent();
        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                var newUC = new StudentStatusUserControl();
                newUC.Dock = DockStyle.Top;
                ResultPanel.Controls.Add(newUC);
            }
        }
    }
}
