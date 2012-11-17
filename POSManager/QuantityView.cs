using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSApplications.Tasks;
using POSApplications.Controllers;
using MVCSharp.Winforms.Configuration;
using MVCSharp.Winforms;
using POSApplications.IViews;
using POSApplications;

namespace POSManager
{
    [WinformsView(typeof(ProcessSaleTask), ProcessSaleTask.QuantityView)]
    public partial class QuantityView : WinFormView, IQuantityView
    {
        public QuantityView()
        {
            InitializeComponent();
        }

        private void QuantityView_Load(object sender, EventArgs e)
        {
            // this.MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;
        }

        private QuantityViewController _quantityViewController
        {
            get
            {
                return Controller as QuantityViewController;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            tbxQuantity.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbxQuantity.Text.ToString().Equals(""))
                {
                    int qty = Int32.Parse(tbxQuantity.Text.ToString());
                    if (qty != 0)
                    {
                        var mpId = _quantityViewController.MenuProductId;
                        _quantityViewController.ChangeQty(mpId, qty);
                        this.Dispose();
                    }
                    else
                    {
                        lblMessage.Text = "* Quantity can not be less than 1";
                        lblMessage.Visible = true;
                    }
                }
                else
                {
                    lblMessage.Text = "* Please enter the quantity";
                    lblMessage.Visible = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input string is not a sequence of digits.");
            }
        }

        private void numericBtn_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            Button button = sender as Button;
            int n = int.Parse(button.Name.Substring(1));
            tbxQuantity.Text = tbxQuantity.Text + n; 
        }

        public void UpdateView()
        {
            tbxQuantity.Text = "";
        }        
    }
}
