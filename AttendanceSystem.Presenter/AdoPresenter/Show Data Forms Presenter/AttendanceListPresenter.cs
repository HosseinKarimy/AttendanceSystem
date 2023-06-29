using AttendanceSystem.DataAccess.UnitOfWork;
using AttendanceSystem.Presenter.IPresenter.Show_Data_Forms;

namespace AttendanceSystem.Presenter.Presenter.Show_Data_Forms_Presenter;

public class AttendanceListPresenter
{
    private readonly IAttendanceListView view;
    private readonly IUnitOFWork unitOFWork;

    public AttendanceListPresenter(IAttendanceListView view, IUnitOFWork unitOFWork)
    {
        this.view = view;
        this.unitOFWork = unitOFWork;

        //events
        view.LoadTeachers += LoadTeachers;
        view.LoadTermCoursesOfTeacher += LoadTermCoursesOfTeacher;
        view.LoadSectionsOfTermCourse += LoadSectionsOfTermCourse;
        view.LoadStudentsStatusOfSection += LoadStudentsStatusOfSection;
        view.LoadStudentsFullInfo += LoadStudentsFullInfo;
        view.UpdateSection += UpdateSection1;
    }

    private void UpdateSection1(object? sender, EventArgs e)
    {
        try
        {
            foreach (var ss in view.StudentStatuses)
            {
                unitOFWork.StudentStatusRepository.Update(ss);
            }
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
    }

    private void LoadStudentsFullInfo(object? sender, EventArgs e)
    {
        try
        {
            var studentId = (int)sender!;
            view.StudentFullInfo = unitOFWork.StudentRepository.GetStudentFullInfo(studentId);
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }

    }

    private void LoadStudentsStatusOfSection(object? sender, EventArgs e)
    {
        try
        {
            view.StudentStatuses = unitOFWork.StudentStatusRepository.GetStudentStatusesBySectionID(view.SelectedSection.SectionID);
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void LoadSectionsOfTermCourse(object? sender, EventArgs e)
    {
        try
        {
            view.Sections = unitOFWork.SectionRepository.GetSectionsOfTermCourseID(view.SelectedTermCourse.TermCourseID);
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void LoadTermCoursesOfTeacher(object? sender, EventArgs e)
    {
        try
        {
            view.TermCoursesOfTeacher = unitOFWork.TermCourseRepository.GetTermCoursesByTeacherID(view.SelectedTeacher.TeacherID);
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

    private void LoadTeachers(object? sender, EventArgs e)
    {
        try
        {
            view.Teachers = unitOFWork.TeacherRepository.GetAll();
            view.IsSucess = true;
        }
        catch (Exception ex)
        {
            view.Message = ex.Message;
            view.IsSucess = false;
        }
    }

}
