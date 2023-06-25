using AttendanceSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.AdoPresenter.OtherManagementPresenter
{
    public partial class OtherManagementPresenter
    {
        private void RaiseTermEvents()
        {
            otherManagementView.SaveCreateTerm += SaveCreateTerm;
            otherManagementView.LoadTerms += LoadTerms;
            otherManagementView.DeleteTerm += DeleteTerm;
        }

        private void DeleteTerm(object? sender, EventArgs e)
        {
            try
            {
                unitOFWork.TermRepository.Delete(otherManagementView.TermModel);
                otherManagementView.Message = "Term Deleted From DataBase...";
                otherManagementView.IsSucess = true;
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }

        private void LoadTerms(object? sender, EventArgs e)
        {
            try
            {
                otherManagementView.Terms = unitOFWork.TermRepository.GetAll();
            }
            catch (Exception ex)
            {
                otherManagementView.Message = ex.Message;
                otherManagementView.IsSucess = false;
            }
        }

        private void SaveCreateTerm(object? sender, EventArgs e)
        {
            switch (otherManagementView.ActionType)
            {
                case ActionType.Create:
                    try
                    {
                        unitOFWork.TermRepository.Add(otherManagementView.TermModel);
                        otherManagementView.Message = "Term Added To DataBase...";
                        otherManagementView.IsSucess = true;
                    }
                    catch (Exception ex)
                    {
                        otherManagementView.Message = ex.Message;
                        otherManagementView.IsSucess = false;
                    }
                    break;
                case ActionType.Update:
                    try
                    {
                        unitOFWork.TermRepository.Update(otherManagementView.TermModel);
                        otherManagementView.Message = "Term Updated From DataBase...";
                        otherManagementView.IsSucess = true;
                    }
                    catch (Exception ex)
                    {
                        otherManagementView.Message = ex.Message;
                        otherManagementView.IsSucess = false;
                    }
                    break;
            }
        }
    }
}
