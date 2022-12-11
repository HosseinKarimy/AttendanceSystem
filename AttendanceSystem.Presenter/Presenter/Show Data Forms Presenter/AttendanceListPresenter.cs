using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

namespace AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;

public class AttendanceListPresenter
{
    private readonly IAttendanceListView view;
    private readonly IUnitOFWork unitOFWork;

    public AttendanceListPresenter(IAttendanceListView view , IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;

        //events
        view.LoadTeachers += View_LoadTeachers;
        view.UpdateSection += View_UpdateSection;
    }

    private void View_UpdateSection(object? sender, EventArgs e)
    {
        try
        {         
            unitOFWork.SectionRepository.Update(view.Section);
            unitOFWork.Save();
            view.IsSucess = true;
            view.Message = "Successful";
        }
        catch (Exception ex)
        {
            view.IsSucess = false;
            if (ex.InnerException is not null)
                view.Message = ex.InnerException.Message;
            else
                view.Message = ex.Message;

        }
        finally
        {
            unitOFWork.ClearTracker();
        }
    }

    private void View_LoadTeachers(object? sender, EventArgs e)
    {
        try
        {
            view.Teachers = unitOFWork.TeacherRepository.GetAllTeachersWithIncludes();
        }
        catch (Exception)
        {

        }
        
    }
}
