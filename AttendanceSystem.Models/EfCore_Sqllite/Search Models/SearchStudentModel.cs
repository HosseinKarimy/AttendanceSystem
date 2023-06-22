using AttendanceSystem.Models.EfCore_Sqllite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Models.Search_Models
{
    public class SearchStudentModel
    {
        public string SearchString { get; set; } = String.Empty;
        public Major Major { get; set; }
        public Grade Grade { get; set; }
        public int EntryYear { get; set; }
    }
}
