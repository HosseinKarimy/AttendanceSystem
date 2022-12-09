﻿using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AttendanceSystem.DataAccess.Repositories;

public class TeacherRepository : Repository<TeacherModel>, ITeacherRepository
{
    private readonly AppDbContext dbContext;

    public TeacherRepository(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public List<TeacherModel> GetAllTeachersWithIncludes()
    {
        return dbContext.Teachers.Include(u => u.Courses).ThenInclude(c => c.Sections).ThenInclude(s=>s.StudentsStatus).ToList();
    }
}
