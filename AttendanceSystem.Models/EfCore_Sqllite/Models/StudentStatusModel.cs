using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Models.EfCore_Sqllite.Models;

public class StudentStatusModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }
    public StudentModel Student { get; set; }

    public bool? IsPresent { get; set; }
    public string Description { get; set; } = string.Empty;
}
