using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;

namespace POSApplications
{
    public class POSContainerController : ControllerBase
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
            }
        }

        public void ActivateLoginView()
        {
            (Task as POSContainerTask).ActivateLoginView();
        }
    }
}
