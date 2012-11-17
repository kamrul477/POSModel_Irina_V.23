using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using POSApplications.Tasks;
using POSModel;
using System.Configuration;
using POSApplications.IViews;

namespace POSApplications.Controllers
{
    public class LoginViewController : ControllerBase
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
                (View as ILoginView).UpdateView();
            }
        }

        public void StartAuthenticationView(Guid empId)
        {
            (Task as LoginTask).StartAuthenticationView(empId);              
        }

        public void CloseApplication()
        {
            (Task as LoginTask).CloseApplication();
        }

        public IEnumerable<IEmployee> GetEmployees()
        {
            return (Task as LoginTask).GetEmployees();
        }

        public void DisposeLoginView()
        {
            (View as ILoginView).DisposeLoginView();
        }
    }
}
