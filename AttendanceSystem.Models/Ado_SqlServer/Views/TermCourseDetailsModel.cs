using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Models.Ado_SqlServer.Views
{
    public record TermCourseDetailsModel(int TermCourseID, int TermID, string CourseName)
    {
        public string CourseInfo => $"{CourseName}-{TermCourseID} , {TermID}";
    }
}
