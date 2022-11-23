using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Models.Search_Models
{
    public class SearchStudentStatusesModel
    {
        public TeacherModel Teacher { get; set; }
        public CourseModel Course { get; set; }
        public SectionModel Section { get; set; }
        public SearchPresenceType PresenceType { get; set; }
    }
}
