using Microsoft.EntityFrameworkCore;
using Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models;

[Index(propertyNames: nameof(StudentId), IsUnique = true)]
public class StudentModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string LastName { get; set; }

    public string? FatherName { get; set; }

    [NotMapped]
    public string FullName { get => $"{FirstName} {LastName}"; }

    [StringLength(50,MinimumLength =8)]
    [Required]
    public string StudentId { get; set; }

    //[Required]
    //public string Password { get; set; } = "1";

    [Required]
    public int EntryYear { get; set; }

    [Required]
    public Major Major { get; set; }
    [Required]
    public Grade Grade { get; set; }

    public DateTime? BirthDate { get; set; }

    public List<CourseModel> Courses { get; set; }
}
