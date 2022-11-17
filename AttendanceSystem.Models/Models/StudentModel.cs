﻿using Microsoft.EntityFrameworkCore;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Models.Models;

[Index(propertyNames: nameof(StudnetId), IsUnique = true)]
public class StudentModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string FatherName { get; set; }

    [StringLength(50,MinimumLength =8)]
    [Required]
    public string StudnetId { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    public Major Major { get; set; }
    [Required]
    public Grade Grade { get; set; }

    public DateTime? BirthDate { get; set; }

    public List<CourseModel> Courses { get; set; }
}
