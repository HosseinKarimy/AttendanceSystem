using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Models.Models;

[Index(propertyNames: nameof(UserName), IsUnique = true)]
public class TeacherModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    public string FatherName { get; set; }

    [StringLength(50, MinimumLength = 8)]
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }

    public DateTime? BirthDate { get ; set; }

    public List<CourseModel> Courses { get; set; }
}
