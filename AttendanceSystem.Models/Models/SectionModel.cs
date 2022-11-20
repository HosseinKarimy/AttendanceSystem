using AttendanceSystem.Models.Models;
using System.ComponentModel.DataAnnotations;

namespace Models.Models;

public class SectionModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public TimeSpan ClassDuration { get; set; }
    [Required]
    public DayOfWeek Day { get; set; }

    public List<StudentStatusModel> StudentsStatus { get; set; } = new();
}
