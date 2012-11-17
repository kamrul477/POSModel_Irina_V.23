using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using POSApplications.Tasks;
using POSApplications.IViews;
using POSModel;

namespace POSApplications.Controllers
{
    public class AuthenticationViewController: ControllerBase
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
                (View as IAuthenticationView).UpdateView();
            }
        }

        //public void BackToLoginScreen()
        //{
        //    (Task as LoginViewTask).BackToLoginScreen();
        //}

        public IEmployee GetEmployee(Guid empId)
        {
            return (Task as LoginTask).GetEmployee(empId);
        }

        public bool AuthenticateEmployee(string password)
        {
            var empId = EmployeeId;
            return (Task as LoginTask).AuthenticateEmployee(empId, password);
        }

        public Guid EmployeeId
        {
            get
            {
                return (Task as LoginTask).EmployeeId;
            }
        }

        public void ActivateTablesView()
        {
            (Task as LoginTask).ActivateTablesView();
        }

        public void DisposeLoginView()
        {
            (Task as LoginTask).DisposeLoginView();
        }
    }
}
