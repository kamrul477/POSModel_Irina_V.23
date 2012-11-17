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
using POSApplication.Tasks;
using POSApplication.IViews;
using POSApplication.Controllers;

namespace POSManager
{
    [WinformsView(typeof(DefineCoversTask), DefineCoversTask.CoversView)]
    public partial class CoversView : WinFormView, ICoversView
    {
        public CoversView()
        {
            InitializeComponent();           
        }

        string _number_of_covers="";

        private void CoversView_Load(object sender, EventArgs e)
        {
             lblCoversDisplay.Text = _number_of_covers;
             this.MdiParent = MDIManager.MDIParent;
             this.Dock = DockStyle.Fill;
        }

        private CoversController _coversController
        {
            get
            {
                return Controller as CoversController;
            }
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            _number_of_covers = _number_of_covers + ((sender as Button).Tag.ToString());
            lblCoversDisplay.Text = _number_of_covers;
        }

        private void btnKeypadEnter_Click(object sender, EventArgs e)
        {
            try
            {
                _number_of_covers = lblCoversDisplay.Text.ToString();
               

                if (!_number_of_covers.Equals(""))
                {
                    int _num_of_covers = int.Parse(_number_of_covers);

                    if (_num_of_covers != 0)
                    {
                        (Controller as CoversController).DefineCovers(_num_of_covers);
                        this.Dispose();
                    }                 
                    else
                    {
                        lblMessage.Text = "* Covers can not be 0";
                        lblMessage.Visible = true;
                    }
                }
                else
                {
                    lblMessage.Text = "* Please enter covers";
                    lblMessage.Visible = true;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("We do not have enough space.\nSorry, Please try somewhere else.", "Error");
                clearCovers();
            }
            catch (FormatException)
            {
                lblMessage.Text = "* Invalid number";
                lblMessage.Visible = true;
            }
        }

        private void btnKeypadClear_click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            clearCovers();
        }
   
        private void clearCovers()
        {
            _number_of_covers = "";
            lblCoversDisplay.Text = _number_of_covers;
        }

        private void btnKeypadCancel_Click(object sender, EventArgs e)
        {
            _coversController.CancelCover();
            this.Dispose();
        }

        public void UpdateView()
        {
            var emp = _coversController.CurrentEmployee;
            lblUserName.Text = emp.FirstName + " " + emp.LastName;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }  
    }
}
