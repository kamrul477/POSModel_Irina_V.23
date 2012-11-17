using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using POSApplication.Tasks;
using POSModel;
using POSApplication.IViews;

namespace POSApplication.Controllers
{
    public  class CoversController : ControllerBase
    {
        public override MVCSharp.Core.Views.IView View
        {
            get
            {
                return base.View;
            }
            set
            {
                base.View = value;
                (View as ICoversView).UpdateView();
            }
        }

        private DefineCoversTask _defineCoversTask
        {
            get
            {
                return Task as DefineCoversTask;
            }
        }

        public IEmployee CurrentEmployee
        {
            get
            {
                return _defineCoversTask.CurrentEmployee;
            }
        }

        public void DefineCovers(int _num_of_covers)
        {
            _defineCoversTask.DefineCovers(_num_of_covers);
        }

        public void CancelCover()
        {
            _defineCoversTask.CancelCovers();
        }
    }
}
