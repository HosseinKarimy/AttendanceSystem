using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

namespace AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;

public class SearchPresenter
{
    private readonly ISearchView view;
    private readonly IUnitOFWork unitOFWork;

    public SearchPresenter(ISearchView view,IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;
        view.LoadStudentsAndTeachers += View_LoadStudentsAndTeachers;
    }

    private void View_LoadStudentsAndTeachers(object? sender, EventArgs e)
    {
        try
        {
            view.AllStudents = unitOFWork.StudentRepository.GetAllStudentsWithIncludes();
            view.AllTeachers = unitOFWork.TeacherRepository.GetAllTeachersWithIncludes();
        }
        catch (Exception)
        {

        }
    }
}
