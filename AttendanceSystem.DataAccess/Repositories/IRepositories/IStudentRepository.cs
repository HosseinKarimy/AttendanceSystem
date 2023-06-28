﻿using AttendanceSystem.Models.Ado_SqlServer;
using AttendanceSystem.Models.Search_Models;

namespace AttendanceSystem.DataAccess.Repositories.IRepositories;

public interface IStudentRepository : IRepository<StudentModel>
{
    List<StudentInfoModel> GetAllWithInfo();
    List<StudentInfoModel> SearchInStudentInfo(SearchStudentModel searchModel);
}
