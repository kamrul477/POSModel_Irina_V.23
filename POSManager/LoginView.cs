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
using POSApplications.Controllers;
using POSApplications.IViews;
using POSModel;
using System.Configuration;
using POSApplications;

namespace POSManager
{

    [WinformsView(typeof(LoginTask), LoginTask.LoginView)]
    public partial class LoginView : WinFormView, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();                   
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;
        }

        private LoginViewController _loginViewController
        {
            get { return Controller as LoginViewController; }
        }

        // populate buttons with the Employee names
        private void loadButtons()
        {
            IEnumerable<IEmployee> employees = _loginViewController.GetEmployees();            

            IEmployee[] emps = employees.ToArray();
            int l = emps.Length;
            Button[] btnArray = new Button[l];

            // Create buttons
            for (int i = 0; i < l; i++)
            {
                btnArray[i] = new Button();
            }

            int n = 0;

            int xPos = 0;
            int yPos = 0; 

            while(n < l)
            {               
                btnArray[n].Tag = emps[n].Id; // Tag of button
                btnArray[n].Width = 175; // Width of button
                btnArray[n].Height = 100; // Height of button
                if (n!=0 && n % 4 == 0) // Location of next line of buttons:
                {
                    xPos = 0;
                    yPos = yPos + btnArray[n].Height;
                }
                // Location of button
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                // Add buttons to a Panel
                pnlButtons.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                xPos = xPos + btnArray[n].Width; // Left of next button
                // attach employee's name to button
                btnArray[n].Text = emps[n].FirstName;
                btnArray[n].Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnArray[n].ForeColor = System.Drawing.Color.Black;
                btnArray[n].Click += new System.EventHandler(btnName_Click); 
                n++;
            }
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var empId = new Guid(button.Tag.ToString());
            _loginViewController.StartAuthenticationView(empId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _loginViewController.CloseApplication();
        }

        public void DisposeLoginView()
        {
            this.Dispose();
        } 

        public void UpdateView()
        {
            loadButtons();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }       
    }
}

