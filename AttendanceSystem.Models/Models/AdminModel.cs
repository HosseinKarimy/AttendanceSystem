using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Models.Models;

[Index(propertyNames: nameof(UserName), IsUnique = true)]
public class AdminModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    public string FatherName { get ; set; } = string.Empty;
    [Required]
    [StringLength(50, MinimumLength = 8)]
    public string UserName { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
}
