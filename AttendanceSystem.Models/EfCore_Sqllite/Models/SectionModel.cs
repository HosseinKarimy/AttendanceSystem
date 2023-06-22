using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AttendanceSystem.Models.EfCore_Sqllite.Models;

public class SectionModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int SectionNumber { get; set; }
    [Required]
    public TimeSpan ClassDuration { get; set; }
    [Required]
    public TimeOnly StartTime { get; set; }
    [Required]
    public DayOfWeek Day { get; set; }
    [Required]
    public DateOnly ClassDate { get; set; }

    [NotMapped]
    public string SectionDetails { get => $"{SectionNumber}: {Day} {ClassDate.ToString()}"; }

    public List<StudentStatusModel> StudentsStatus { get; set; } = new();
}
