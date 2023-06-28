using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.ViewModels;
using AttendanceSystem.Presenter.IPresenter;

namespace AttendanceSystem.WinFormUI
{
    public partial class SectionUserControl : UserControl , ISectionUCView
    {
        public SectionUserControl()
        {
            InitializeComponent();
        }

        public SectionPerWeekModel SectionPerWeek { get; set; }

        public event EventHandler RemoveSection;

        private void SectionUserControl_Load(object sender, EventArgs e)
        {
            ClassDurationMAskedTextBox.Text = SectionPerWeek.Duration.ToString();
            ClassDayTextBox.Text = SectionPerWeek.Day.ToString();
            StartTimeTextBox.Text = SectionPerWeek.StartTime.ToString();
        }

        private void RemoveSectionButton_Click(object sender, EventArgs e)
        {
            RemoveSection?.Invoke(this, EventArgs.Empty);
        }
    }
}
