using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models;

[Index(propertyNames: nameof(TeacherId), IsUnique = true)]
public class TeacherModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string LastName { get; set; }

    public string FatherName { get; set; }
    [NotMapped]
    public string FullName { get => $"{FirstName} {LastName}"; }

    [StringLength(50, MinimumLength = 8)]
    [Required]
    public string TeacherId { get; set; }
    [Required]
    public string Password { get; set; } = "1";

    public DateTime? BirthDate { get ; set; }

    public List<CourseModel> Courses { get; set; }
}
