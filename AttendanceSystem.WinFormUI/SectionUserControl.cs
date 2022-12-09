using AttendanceSystem.Presenter.IPresenter;
using Models.Models;
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
    public partial class SectionUserControl : UserControl , ISectionUCView
    {
        public SectionUserControl()
        {
            InitializeComponent();
        }

        public SectionModel SectionModel { get; set; }
        public event EventHandler RemoveSection;

        private void SectionUserControl_Load(object sender, EventArgs e)
        {
            ClassDurationMAskedTextBox.Text = SectionModel.ClassDuration.ToString();
            ClassDayTextBox.Text = SectionModel.Day.ToString();
            StartTimeTextBox.Text = SectionModel.StartTime.ToString();
        }

        private void RemoveSectionButton_Click(object sender, EventArgs e)
        {
            RemoveSection?.Invoke(this, EventArgs.Empty);
        }
    }
}
