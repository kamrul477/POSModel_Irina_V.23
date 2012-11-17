using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSModel;
using POSApplication.Tasks;
using POSApplications.IViews;

namespace POSApplications.Tasks
{
    public class QuantityViewController: ControllerBase
    {
        public override IView View
        {
            get
            {
                return base.View;
            }
            set
            {
                base.View = value;
                (View as IQuantityView).UpdateView();
            }
        }

        private ProcessSaleTask _processSaleTask
        {
            get
            {
                return (Task as ProcessSaleTask);
            }
        }

        public Guid MenuProductId
        {
            get
            {
                return _processSaleTask.MenuProductId;
            }
        }

        public void ChangeQty(Guid menuProductId, int qty)
        {
            _processSaleTask.ChangeQty(menuProductId, qty);
        }
    }
}
