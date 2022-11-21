using AttendanceSystem.DataAccess.Data;
using AttendanceSystem.DataAccess.Repositories.IRepositories;
using Models.Models;

namespace AttendanceSystem.DataAccess.Repositories;

public class SectionRepository : Repository<SectionModel>, ISectionRepository
{
    public SectionRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
