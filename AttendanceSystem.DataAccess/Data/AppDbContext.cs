using AttendanceSystem.Models.Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace AttendanceSystem.DataAccess.Data;

public class AppDbContext : DbContext
{
    public string DbPath { get; }

    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "AttendanceSystem.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<SectionModel> Sections { get; set; }
    public DbSet<StudentModel> Students { get; set; }
    public DbSet<StudentStatusModel> StudentsStatus { get; set; }
    public DbSet<TeacherModel> Teachers { get; set; }
}

