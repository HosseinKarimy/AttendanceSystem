using AttendanceSystem.Models.EfCore_Sqllite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter;

public partial interface IClassManagementView
{
    public CourseModel CourseModel { get; set; }

    public List<TeacherModel> Teachers { get; set; }

    public event EventHandler CourseSaveEdit;
    public event EventHandler LoadTeachers;
}
