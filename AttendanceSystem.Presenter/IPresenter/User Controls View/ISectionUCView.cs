using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Presenter.IPresenter
{
    public interface ISectionUCView
    {
        public SectionModel SectionModel { get; set; }

        public event EventHandler RemoveSection;
    }
}
