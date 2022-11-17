using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Models.Models
{
    public class StudentStatusModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }
        public StudentModel Student{ get; set; }

        [Required]
        public bool IsPresent { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
