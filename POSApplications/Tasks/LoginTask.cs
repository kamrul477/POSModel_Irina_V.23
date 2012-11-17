using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;
using POSApplications.Controllers;
using POSModel;
using System.Configuration;
using Controller;

namespace POSApplications.Tasks
{
    public class LoginTask: POSBaseTask
    {
        [InteractionPoint(typeof(LoginViewController), IsCommonTarget = true)]
        public const string LoginView = "LoginView";

        [InteractionPoint(typeof(AuthenticationViewController), IsCommonTarget = true)]
        public const string AuthenticationView = "AuthenticationView";

        public override void OnStart(object param)
        {
            Navigator.ActivateView(LoginView);
        }

        public Guid EmployeeId { get; set; }

        public void StartAuthenticationView(Guid empId)
        {
            EmployeeId = empId;
            Navigator.ActivateView(AuthenticationView);            
        }

        public void CloseApplication()
        {
            Environment.Exit(0);
        }

        public IEnumerable<IEmployee> GetEmployees()
        {
            return System.GetEmployees(Company.Id, Store.Id);
        }

        public IEmployee GetEmployee(Guid empId)
        {
            return System.GetEmployee(Company.Id, empId);
        }

        public bool AuthenticateEmployee(Guid empId, string password)
        {
            return System.AuthenticateEmployee(Company.Id, empId, password);        
        }

        public void ActivateTablesView()
        {
            using (System){}
            this.TasksManager.StartTask(typeof(TableViewTask), new object[] { EmployeeId });                       
        }

        public void DisposeLoginView()
        {
           (Navigator.GetController(LoginView) as LoginViewController).DisposeLoginView();
        }
    }
}
