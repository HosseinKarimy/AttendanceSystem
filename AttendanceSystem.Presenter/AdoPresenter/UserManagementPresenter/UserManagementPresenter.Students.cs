namespace AttendanceSystem.Presenter.AdoPresenter.UserManagementPresenter;

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
        if (userManagementView.ActionType == ActionType.Create)
        {
            try
            {
                ModelValidation.IsValid<StudentModel>(userManagementView.StudentModel);
                unitOFWork.StudentRepository.Add(userManagementView.StudentModel);
                unitOFWork.UserRepository.Add(new UserModel() { StudentModel = userManagementView.StudentModel , Username = userManagementView.StudentModel .StudentId , Password = "1" , Role = Role.Student});
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
        else if (userManagementView.ActionType == ActionType.Update)
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
        if (userManagementView.ActionType == ActionType.Delete)
        {
            try
            {
                var target = unitOFWork.StudentRepository.FirstOrDefault(u => u.Id == userManagementView.StudentModel.Id);                
                unitOFWork.UserRepository.Delete(unitOFWork.UserRepository.FirstOrDefault(u => u.StudentId == target.Id));
                unitOFWork.StudentRepository.Delete(target);
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
