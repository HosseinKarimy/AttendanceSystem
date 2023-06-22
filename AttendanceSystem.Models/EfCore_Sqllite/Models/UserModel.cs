using AttendanceSystem.Models.EfCore_Sqllite.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models.EfCore_Sqllite.Models;

[Index(propertyNames: nameof(Username), IsUnique = true)]
public class UserModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    public Role Role { get; set; }

    [ForeignKey("AdminModel")]
    public int? AdminId { get; set; }
    public AdminModel? AdminModel { get; set; } = null;

    [ForeignKey("TeacherModel")]
    public int? TeacherId { get; set; }
    public TeacherModel? TeacherModel { get; set; } = null;

    [ForeignKey("StudentModel")]
    public int? StudentId { get; set; }
    public StudentModel? StudentModel { get; set; } = null;
}
