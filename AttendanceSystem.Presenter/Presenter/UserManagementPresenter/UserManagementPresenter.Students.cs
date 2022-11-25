﻿using AttendanceSystem.Models.ModelValidator;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Models.Models;

namespace AttendanceSystem.Presenter.Presenter.UserManagementPresenter;

public partial class UserManagementPresenter
{
    private void RaiseStudentsEvents()
    {
        userManagementView.StudentSaveEdit += UserManagementView_StudentSaveEdit;
        userManagementView.LoadStudents += UserManagementView_LoadStudents;
        userManagementView.StudentDelete += UserManagementView_StudentDelete;
    }
    

    private void UserManagementView_LoadStudents(object? sender, EventArgs e)
    {
        userManagementView.Students = unitOFWork.StudentRepository.GetAll();
    }
    private void UserManagementView_StudentSaveEdit(object? sender, EventArgs e)
    {
        if (userManagementView.ActionType == Models.Enums.ActionType.Create)
        {
            try
            {
                ModelValidation.IsValid<StudentModel>(userManagementView.StudentModel);
                unitOFWork.StudentRepository.Add(userManagementView.StudentModel);
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
                ModelValidation.IsValid<StudentModel>(userManagementView.StudentModel);
                unitOFWork.StudentRepository.Update(userManagementView.StudentModel);
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
    private void UserManagementView_StudentDelete(object? sender, EventArgs e)
    {
        if (userManagementView.ActionType == Models.Enums.ActionType.Delete)
        {
            try
            {
                unitOFWork.StudentRepository.Delete(userManagementView.StudentModel);
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
