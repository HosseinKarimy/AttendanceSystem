using AttendanceSystem.Presenter.IPresenter.OtherManagementView;

namespace AttendanceSystem.Presenter.Presenter.ClassManagementPresenter;

public partial class ClassManagementPresenter
{
    private void RaiseStudentSectionEvents()
    {
        view.LoadStudents += View_LoadStudents;
        view.LoadDegreesAndMajors += LoadDegreesAndMajors;
        view.SearchStudents += SearchStudents;
    }

    private void SearchStudents(object? sender, EventArgs e)
    {
        try
        {
            view.Students = unitOFWork.StudentRepository.SearchInStudentInfo(view.SearchStudentModel);
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void LoadDegreesAndMajors(object? sender, EventArgs e)
    {
        try
        {
            view.Degrees = unitOFWork.DegreeRepository.GetAll();
            view.Majors = unitOFWork.MajorRepository.GetAll();
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void View_LoadStudents(object? sender, EventArgs e)
    {
        try
        {
            view.Students = unitOFWork.StudentRepository.GetAllWithInfo();
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }        
    }
}
