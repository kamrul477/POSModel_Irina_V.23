using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSApplications.Tasks;
using POSApplications.IViews;
using POSApplications.Controllers;
using POSApplications;


namespace POSManager
{
    [WinformsView(typeof(LoginTask), LoginTask.AuthenticationView)]
    public partial class AuthenticationView : WinFormView, IAuthenticationView
    {
        public AuthenticationView()
        {
            InitializeComponent();
        }

        private void AuthenticationView_Load(object sender, EventArgs e)
        {
            //this.MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;
        }

        private  AuthenticationViewController _authenticationViewController
        {
            get
            {
                return Controller as AuthenticationViewController;
            }
        }

        private void showCurrentUserName()
        {
            var empId = _authenticationViewController.EmployeeId;
            var emp = _authenticationViewController.GetEmployee(empId);
            lblUserName.Text = emp.FirstName + " " + emp.LastName;
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            Button button = sender as Button;
            int n = int.Parse(button.Name.Substring(1));
            tBxPassword.Text = tBxPassword.Text + n;           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 

        private void bntClear_Click(object sender, EventArgs e)
        {
            tBxPassword.Text = "";
            lblMessage.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var password = tBxPassword.Text.ToString();

            if (!password.Equals(""))
            {
                if (_authenticationViewController.AuthenticateEmployee(password) == true)
                {
                    _authenticationViewController.ActivateTablesView();
                    _authenticationViewController.DisposeLoginView();
                    this.Dispose();
                }
                else
                {                    
                    lblMessage.Text = "* Wrong Password";
                    lblMessage.Visible = true;
                }
            }
            else
            {
                lblMessage.Text = "* Please enter your password";
                lblMessage.Visible = true;
            }
        }

        public void UpdateView()
        {
            showCurrentUserName();
            tBxPassword.Text = "";
        }
    }
}
