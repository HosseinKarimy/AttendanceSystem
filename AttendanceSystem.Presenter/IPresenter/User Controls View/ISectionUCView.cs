using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.ViewModels;

namespace AttendanceSystem.Presenter.IPresenter;

public interface ISectionUCView
{
    public SectionPerWeekModel SectionPerWeek { get; set; }

    public event EventHandler RemoveSection;
}
