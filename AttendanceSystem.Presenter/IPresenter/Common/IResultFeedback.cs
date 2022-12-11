using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter.Common
{
    public interface IResultFeedback
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
    }
}
