using AttendanceSystem.Models.Models;
using Microsoft.EntityFrameworkCore;
using Models.Enums;
using Models.Models;

namespace AttendanceSystem.DataAccess.Data;

public class AppDbContext : DbContext
{
    public string DbPath { get; }

    public AppDbContext()
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        //DbPath = System.IO.Path.Join(path, "AttendanceSystem.db");
        DbPath = System.IO.Path.Join(AppContext.BaseDirectory, "AttendanceSystem.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source= {DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentModel>().HasData(
            new StudentModel() { Id=1, FirstName = "hossein"  , LastName = "Km" , StudentId = "1111111111", Major = Major.Computer , Grade = Grade.Bachelor , EntryYear = 1398 , FatherName = "Ali"},
            new StudentModel() { Id=2, FirstName = "hamed", LastName = "gk", StudentId = "2222222222", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "habib" },
            new StudentModel() { Id = 3, FirstName = "reza", LastName = "mohammadi", StudentId = "123213133", Major = Major.Mechanics, Grade = Grade.Bachelor, EntryYear = 1397, FatherName = "mohammad" },
            new StudentModel() { Id = 4, FirstName = "ali", LastName = "aghaii", StudentId = "432432123", Major = Major.Computer, Grade = Grade.Bachelor, EntryYear = 1398, FatherName = "taghi" }
            );
        modelBuilder.Entity<TeacherModel>().HasData(
            new TeacherModel() { Id=1, FirstName = "Amin" , LastName = "Enayat", TeacherId="18238213"},
            new TeacherModel() { Id = 2, FirstName = "Mehdi", LastName = "Enayat", TeacherId = "43243243" },
            new TeacherModel() { Id = 3, FirstName = "somaye", LastName = "amraee", TeacherId = "243425345" },
            new TeacherModel() { Id = 4, FirstName = "mousa", LastName = "mousa zade", TeacherId = "344351234" }
            );
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<SectionModel> Sections { get; set; }
    public DbSet<StudentModel> Students { get; set; }
    public DbSet<StudentStatusModel> StudentsStatus { get; set; }
    public DbSet<TeacherModel> Teachers { get; set; }
}

