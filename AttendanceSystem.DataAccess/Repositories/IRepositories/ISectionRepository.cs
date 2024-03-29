﻿using AttendanceSystem.Models.Ado_SqlServer;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface ISectionRepository : IRepository<SectionModel>
{
    public List<SectionModel> GetSectionsOfTermCourseID(int TermCourseID);
}
