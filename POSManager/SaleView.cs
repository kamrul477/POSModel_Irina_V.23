using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MVCSharp.Winforms.Configuration;
using POSApplications.Tasks;
using MVCSharp.Winforms;
using POSManager;
using POSApplications.IViews;
using POSModel;
using System.Drawing.Printing;


namespace POSUI
{
    [WinformsView(typeof(ProcessSaleTask), ProcessSaleTask.SaleView)]
    public partial class SaleView : WinFormView, ISaleView
    {
        public SaleView()
        {
            InitializeComponent();
        }
        
        private void Load_SaleView(object sender, EventArgs e)
        {
            this.MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;
        }

        private SaleViewController _saleViewController
        {
            get { return Controller as SaleViewController; }
        }

        private void showCurrentUserName()
        {
            var emp = _saleViewController.CurrentEmployee;
           // lblUserName.Text = emp.FirstName + " " + emp.LastName;
        }
        
        private void showTable()
        {
            btnTable.Text = "Table: " + _saleViewController.CurrentTable.Description;
        }

        private void showCovers()
        {
            btnCovers.Text = "Covers: " + (int)(_saleViewController.CurrentCovers);
        }

        // Create buttons and populate them with the category names
        private void loadCategoryButtons()
        {
            IEnumerable<ICategory> categories = _saleViewController.GetCategories();

            ICategory[] cats = categories.ToArray();
            int l = cats.Length;
            Button[] btnArray = new Button[l];

            // Create buttons
            for (int i = 0; i < l; i++)
            {
                btnArray[i] = new Button();
            }

            int n = 0;
            int xPos = 0;
            int yPos = 0; 

            while (n < l)
            {  
                btnArray[n].Tag = cats[n]; // Tag of button
                btnArray[n].Width = 145; // Width of button
                btnArray[n].Height = 70; // Height of button
                if (n != 0 && n % 4 == 0) // Location of next line of buttons
                {
                    xPos = 0;
                    yPos = yPos + btnArray[n].Height;
                }
                // Location of button
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                // Add buttons to Panel
                pnlCategoryButtons.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                xPos = xPos + btnArray[n].Width; // Left of next button
                // Attach category name to button
                string name = cats[n].Description.Trim();
                btnArray[n].Text = name.ToUpper();
                cats[n].FontColor = Color.White;
                btnArray[n].ForeColor = cats[n].FontColor;

                btnArray[n].Font = new Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                setCategoryColor(cats, btnArray, n, name);                    
                btnArray[n].TextAlign = ContentAlignment.MiddleCenter;
                btnArray[n].Click += new System.EventHandler(btnCategory_Click);
                n++;
            }
        }

        private static void setCategoryColor(ICategory[] cats, Button[] btnArray, int n, string name)
        {
            switch (name)
            {
                case "Entree":
                    btnArray[n].BackColor = Color.Silver;
                    cats[n].Color = Color.Silver;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Burger":
                    btnArray[n].BackColor = Color.OliveDrab;
                    cats[n].Color = Color.OliveDrab;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Salad":
                    btnArray[n].BackColor = Color.Green;
                    cats[n].Color = Color.Green;
                    break;
                case "Side":
                    btnArray[n].BackColor = Color.DarkOrange;
                    cats[n].Color = Color.DarkOrange;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Soup":
                    btnArray[n].BackColor = Color.Tan;
                    cats[n].Color = Color.Tan;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Antipasti":
                case "Antipasti di Mare":
                    btnArray[n].BackColor = Color.Blue;
                    cats[n].Color = Color.Blue;
                    break;
                case "Pasta":
                case "Risotto":
                    btnArray[n].BackColor = Color.Red;
                    cats[n].Color = Color.Red;
                    break;
                case "Fish":
                case "Veal":
                case "Chicken":
                case "Beef":
                case "Pork":
                case "Lamb":
                    btnArray[n].BackColor = Color.Purple;
                    cats[n].Color = Color.Purple;
                    break;
                case "Soft Drink":
                    btnArray[n].BackColor = Color.LightSkyBlue;
                    cats[n].Color = Color.LightSkyBlue;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Coffee":
                    btnArray[n].BackColor = Color.Maroon;
                    cats[n].Color = Color.Maroon;
                    break;
                case "Red Wine":
                    btnArray[n].BackColor = Color.Crimson;
                    cats[n].Color = Color.Crimson;
                    break;
                case "White Wine":
                    btnArray[n].BackColor = Color.Yellow;
                    cats[n].Color = Color.Yellow;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                case "Desert":
                    btnArray[n].BackColor = Color.DeepPink;
                    cats[n].Color = Color.DeepPink;
                    cats[n].FontColor = Color.Black;                    
                    btnArray[n].ForeColor = cats[n].FontColor;
                    break;
                default:
                    break;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            groupBoxCategory.Visible = false;
            Button button = sender as Button;
            var category = button.Tag as ICategory;
            showProductsPanel(category);
        }

        public void showProductsPanel(ICategory category)
        {
            groupBoxProducts.Text = category.Description.ToUpper().Trim();
            var products = _saleViewController.GetCategoryMenuProducts(category.Id);
            int count = products.Length;
            var buttons = pnlButtons.Controls;

            refreshButtons(count, buttons);

            try
            {
                for (int i = 0; i < count; i++)
                {
                    buttons[i].Tag = products[i];
                    buttons[i].Text = products[i].Description.Trim();
                    buttons[i].BackColor = category.Color;
                    buttons[i].Font = new Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    buttons[i].ForeColor = category.FontColor;
                }            
            }
            catch (IndexOutOfRangeException){}
            groupBoxProducts.Visible = true;
        }

        private static void refreshButtons(int count, Control.ControlCollection buttons)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Tag = null;
                buttons[i].Text = null;
                buttons[i].BackColor = Color.Gainsboro;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var menuProductId = (button.Tag as IMenuProduct).Id;
            (Controller as SaleViewController).AddSaleLineItem(menuProductId);
            updateDataGridView();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            groupBoxProducts.Visible = false;
            groupBoxCategory.Visible = true;
        }        

        //to get selected SLI from DataGridView
        private ISaleLineItem getSelectedSli()
        {
            ISaleLineItem selectedItem = null;

            if (SLIGridView.SelectedCells.Count != 0)
            {
                // to get data from a selected row of DataGridView
                selectedItem = (ISaleLineItem)SLIGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                throw new NullReferenceException("The item should be selected first!");
            }
            return selectedItem;
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                var mpId = getSelectedSli().MenuProductId;
                _saleViewController.ActivateQuantityView(mpId);
                updateDataGridView();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            try
            {
                var mpId = getSelectedSli().MenuProductId;
                _saleViewController.IncrementQty(mpId);
                updateDataGridView();
            }
            catch (NullReferenceException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            try
            {
                var mpId = getSelectedSli().MenuProductId;
                _saleViewController.DecrementQty(mpId);
                updateDataGridView();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkEmployeePermissions(string code)
        {
            var emp = _saleViewController.CurrentEmployee;
            IEnumerable<IPermission> empPermissions = emp.Permissions;
            bool b = false;
            foreach (var p in empPermissions)
            {
                if (p.code.Equals(code))
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var code = button.Tag as string;
            bool b = checkEmployeePermissions(code);
            if (b == true)
            {
                try
                {
                    var menuProductId = getSelectedSli().MenuProductId;
                    _saleViewController.RemoveSaleLineItem(menuProductId);
                    updateDataGridView();
                }
                catch (NullReferenceException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You don't have a permission to clear SLI");
            }
        }        

        private void voidButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var code = button.Tag as string;
            bool b = checkEmployeePermissions(code);
            if (b == true)
            {
                _saleViewController.RemoveSale();
                _saleViewController.BackToTableView((bool)(sender as Button).Tag);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("You don't have a permission to void Sale");
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var code = button.Tag as string;
            bool b = checkEmployeePermissions(code);
            if (b == true)
            {
                if (_saleViewController.CurrentSale.SaleLineItems.Count() == 0)
                {
                    MessageBox.Show("The items should be selected first!");
                }
                else
                {
                    _saleViewController.ActivatePaymentView();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("You don't have a permission to make payment");
            }
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            _saleViewController.BackToTableView(Boolean.Parse(((sender as Button).Tag).ToString()));
            this.Dispose();
        }

        private void btnChangeCovers_Click(object sender, EventArgs e)
        {
            _saleViewController.BackToCoversView();
            this.Dispose();
        }

        private void btnBackToTables_Click(object sender, EventArgs e)
        {
            _saleViewController.BackToTableView(Boolean.Parse(((sender as Button).Tag).ToString())); 
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _saleViewController.BackToLoginView();
            this.Dispose();
        }


        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            sendOrderToKitchen();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            printReceipt();
        }

        private void updatePanelSaleDetails()
        {
            lblTotalGST.Text = _saleViewController.CurrentSale.GST.ToString("#.00");
            lblTotalSale.Text = _saleViewController.CurrentSale.Total.ToString("#.00");
        }


        private void updateDataGridView()
        {
            if (_saleViewController.CurrentSale.SaleLineItems.Count() != 0)
            {
                SLIGridView.AutoGenerateColumns = false;
                SLIGridView.DataSource = typeof(ISaleLineItem);
                SLIGridView.DataSource = _saleViewController.CurrentSale.SaleLineItems;
                updatePanelSaleDetails();
            }
        }

        public void UpdateView()
        {
            showCurrentUserName();
            showTable();
            showCovers();
            loadCategoryButtons();
            updateDataGridView();
            updatePanelSaleDetails();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void printReceipt()
        {
            var dialog = new PrintDialog();
            var document = new PrintDocument();

            dialog.Document = document;
            document.PrintPage += new PrintPageEventHandler(document_PrintBill);

            //save the user's choice
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void sendOrderToKitchen()
        {
            var dialog = new PrintDialog();
            var document = new PrintDocument();

            dialog.Document = document;
            document.PrintPage += new PrintPageEventHandler(document_SendOrder);

            //save the user's choice
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }
        void document_SendOrder(object sender, PrintPageEventArgs e)
        {
            _saleViewController.SendOrder(sender, e);
        }

        void document_PrintBill(object sender, PrintPageEventArgs e)
        {
            _saleViewController.PrintBill(sender, e);
        }

    }
}
