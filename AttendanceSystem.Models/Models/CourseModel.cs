﻿using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace Models.Models;

public class CourseModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public int NumberOfSections { get; set; }

    [Required]
    public DateTime CourseStartDate { get; set; }

    public DateTime? MidTermExam { get; set; }
    public DateTime? FinalExam { get; set; }

    [Required]
    public int TeacherId { get; set; }
    public TeacherModel Teacher { get; set; }

    public List<SectionModel> Sections { get; set; }
    public List<StudentModel> Students { get; set; }
}
