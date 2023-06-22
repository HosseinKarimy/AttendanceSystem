using AttendanceSystem.Models.EfCore_Sqllite.Enums;

namespace AttendanceSystem.Presenter.Presenter.ClassManegementPresenter;

public partial class ClassManegementPresenter
{
    private void RaiseStudentSectionEvents()
    {
        view.LoadStudents += View_LoadStudents;
        view.Search += View_Search;
    }
   
    private void View_Search(object? sender, EventArgs e)
    {
        var searchModel = view.SearchStudentModel;
        var students = unitOFWork.StudentRepository.GetAll();
        students = students.Where(u => u.StudentId.Contains(searchModel.SearchString) || u.FullName.Contains(searchModel.SearchString)).ToList();
        if (searchModel.Grade != Grade.none)
            students = students.Where(u => u.Grade == searchModel.Grade).ToList();
        if (searchModel.Major != Major.none)
            students = students.Where(u => u.Major == searchModel.Major).ToList();
        if (searchModel.EntryYear != 0)
            students = students.Where(u => u.EntryYear == searchModel.EntryYear).ToList();
        view.Students = students;
    }

    private void View_LoadStudents(object? sender, EventArgs e)
    {
        view.Students = unitOFWork.StudentRepository.GetAll();
    }
}
