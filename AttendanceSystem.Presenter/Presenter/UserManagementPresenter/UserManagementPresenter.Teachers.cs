using AttendanceSystem.Models.ModelValidator;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.Presenter.UserManagementPresenter
{
    public partial class UserManagementPresenter
    {
        private void RaiseTeachersEvents()
        {
            userManagementView.TeacherSaveEdit += UserManagementView_TeacherSaveEdit;
            userManagementView.LoadTeachers += UserManagementView_LoadTeachers;
            userManagementView.TeacherDelete += UserManagementView_TeacherDelete;
        }

        private void UserManagementView_LoadTeachers(object? sender, EventArgs e)
        {
            userManagementView.Teachers = unitOFWork.TeacherRepository.GetAll();
        }
        private void UserManagementView_TeacherSaveEdit(object? sender, EventArgs e)
        {
            if (userManagementView.ActionType == Models.Enums.ActionType.Create)
            {
                try
                {
                    ModelValidation.IsValid<TeacherModel>(userManagementView.TeacherModel);
                    unitOFWork.TeacherRepository.Add(userManagementView.TeacherModel);
                    unitOFWork.Save();
                    userManagementView.IsSucess = true;
                    userManagementView.Message = "Added Successfully";
                }
                catch (Exception ex)
                {
                    userManagementView.IsSucess = false;
                    if (ex.InnerException is not null)
                        userManagementView.Message = ex.InnerException.Message;
                    else
                        userManagementView.Message = ex.Message;

                }
                finally
                {
                    unitOFWork.ClearTracker();
                }

            }
            else if (userManagementView.ActionType == Models.Enums.ActionType.Update)
            {
                try
                {
                    ModelValidation.IsValid<TeacherModel>(userManagementView.TeacherModel);
                    unitOFWork.TeacherRepository.Update(userManagementView.TeacherModel);
                    unitOFWork.Save();
                    userManagementView.IsSucess = true;
                    userManagementView.Message = "Updated Successfully";
                }
                catch (Exception ex)
                {
                    userManagementView.IsSucess = false;
                    if (ex.InnerException is not null)
                        userManagementView.Message = ex.InnerException.Message;
                    else
                        userManagementView.Message = ex.Message;

                }
                finally
                {
                    unitOFWork.ClearTracker();
                }

            }
        }
        private void UserManagementView_TeacherDelete(object? sender, EventArgs e)
        {
            if (userManagementView.ActionType == Models.Enums.ActionType.Delete)
            {
                try
                {
                    unitOFWork.TeacherRepository.Delete(userManagementView.TeacherModel);
                    unitOFWork.Save();
                    userManagementView.IsSucess = true;
                    userManagementView.Message = "Deleted Successfully";
                }
                catch (Exception ex)
                {
                    userManagementView.IsSucess = false;
                    if (ex.InnerException is not null)
                        userManagementView.Message = ex.InnerException.Message;
                    else
                        userManagementView.Message = ex.Message;
                }
                finally
                {
                    unitOFWork.ClearTracker();
                }

            }
        }
    }
}
