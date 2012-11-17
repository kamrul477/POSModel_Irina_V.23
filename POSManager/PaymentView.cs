using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Winforms.Configuration;
using POSApplication.Controllers;
using POSApplication.Tasks;
using MVCSharp.Winforms;
using POSApplication.IViews;
using POSModel;

namespace POSManager
{
    [WinformsView(typeof(PaymentTask), PaymentTask.PaymentView)]
    public partial class PaymentView : WinFormView, IPaymentView
    {
        private bool decimalActivated = false;

        public PaymentView()
        {
            InitializeComponent();
        }

        private PaymentController _paymentViewController
        {
            get
            {
                return (Controller as PaymentController);
            }
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {
            this.MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;

            tbxPaymentAmountDisplay.Tag = (decimal)0.00;

            updateSaleLineItemGridView();
            updatePaymentGridView();
        }

        private void NumericKeyClick(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Decimal amount = (Decimal)tbxPaymentAmountDisplay.Tag;
            if (!decimalActivated)
            {
                if (amount > (decimal)0.0)
                {
                    if (Decimal.Remainder(amount, 1) > (decimal)0.001)
                    {
                        Decimal.TryParse(String.Format("{0:0.00}", amount + button.Tag.ToString()), out amount);
                        amount = Decimal.Truncate(amount * 100) / 100;
                    }
                    else
                    {
                        Decimal.TryParse(String.Format("{0:0.00}", amount + button.Tag.ToString()), out amount);
                    }
                }
                else
                {
                    Decimal.TryParse(String.Format("{0:0.00}", amount + button.Tag.ToString()), out amount);
                    amount = Decimal.Truncate(amount * 100) / 100;
                }
                SetPaymentKeypadTextBoxAmount(amount);
            }
            else
            {
                Decimal.TryParse(String.Format("{0:0.00}", amount + "." + button.Tag.ToString()), out amount);
                SetPaymentKeypadTextBoxAmount(amount);
                decimalActivated = false;
            }
        }

        private void SetPaymentKeypadTextBoxAmount(decimal amount)
        {
            tbxPaymentAmountDisplay.Tag = amount;
            tbxPaymentAmountDisplay.Text = String.Format("{0:c}", amount);
            UpdateView();
        }

        private void btnKeypadDot_Click(object sender, EventArgs e)
        {
            decimalActivated = true;
        }

        private void btnKeypadClear_Click(object sender, EventArgs e)
        {
            CleartxbPaymentAmountDisplaly();
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            _paymentViewController.ActivateLoginTask();
        }

        private void btnKeypadEnter_Click(object sender, EventArgs e)
        {
           var canFinalise =  _paymentViewController.FinaliseSale(_paymentViewController.GetSaleChange());
            if (canFinalise)
            {
                printInvoice();
            }

        }
        private void printInvoice()
        {
            //var dialog = new PrintDialog();
            var document = new PrintDocument();

            //dialog.Document = document;
            document.PrintPage += new PrintPageEventHandler(document_PrintInVoice);

            //save the user's choice
            //var result = dialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
                document.Print();
            //}
        }

        private void document_PrintInVoice(object sender, PrintPageEventArgs e)
        {
            _paymentViewController.PrintInvoice(sender, e);
        }

        #region IPaymentView Members

        public void UpdateView()
        {
            lblUserName.Text = _paymentViewController.CurrentEmployee.FirstName + " " + _paymentViewController.CurrentEmployee.LastName;
            lblTotalAmountDisplay.Text = string.Format("{0:c}", _paymentViewController.GetSaleTotalPrice());
            lblPaidAmountDisplay.Text = string.Format("{0:c}", _paymentViewController.GetSaleTotalPaid());
            lblChangeDisplay.Text = string.Format("{0:c}", _paymentViewController.GetSaleChange());

            updatePaymentGridView();

            btnKeypadEnter.Enabled = _paymentViewController.GetSaleTotalPaid() >= _paymentViewController.GetSaleTotalPrice();
            btnBackToSale.Enabled = !(_paymentViewController.GetSaleTotalPaid() >= _paymentViewController.GetSaleTotalPrice());

            btnCash.Enabled = false;
            btnEftpos.Enabled = false;
            if (tbxPaymentAmountDisplay.Tag != null )
            {
                btnCash.Enabled = ((decimal)tbxPaymentAmountDisplay.Tag > 0);
            }
            if (tbxPaymentAmountDisplay.Tag != null )
            {
                btnEftpos.Enabled = ((decimal)tbxPaymentAmountDisplay.Tag > 0);
            }
            btnKeypadRemove.Enabled = _paymentViewController.CurrentSale.Payments.Count() > 0;
        }

        #endregion

        private void btnCash_Click(object sender, EventArgs e)
        {
            _paymentViewController.AddCashPayment((decimal)tbxPaymentAmountDisplay.Tag);
            CleartxbPaymentAmountDisplaly();
            UpdateView();
        }

        private void CleartxbPaymentAmountDisplaly()
        {
            SetPaymentKeypadTextBoxAmount(0);
            if (decimalActivated)
            {
                decimalActivated = false;
            }
        }

        private void btnEftpos_Click(object sender, EventArgs e)
        {
            _paymentViewController.AddEftposPayment((decimal)tbxPaymentAmountDisplay.Tag);
            CleartxbPaymentAmountDisplaly();
            UpdateView();
        }

        private void btnBackToSale_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _paymentViewController.ActivateSaleTask();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _paymentViewController.ActivateLoginTask();
        }


        private void updateSaleLineItemGridView()
        {
            SaleLineItemGridView.DataSource = null;
            if (_paymentViewController.CurrentSale.SaleLineItems.Count() != 0)
            {
                SaleLineItemGridView.AutoGenerateColumns = false;
                SaleLineItemGridView.DataSource = typeof(ISaleLineItem);
                SaleLineItemGridView.DataSource = _paymentViewController.CurrentSale.SaleLineItems;
            }
        }

        private void updatePaymentGridView()
        {
            if (_paymentViewController.CurrentSale.Payments.Count() != 0)
            {
                PaymentGridView.AutoGenerateColumns = false;
                PaymentGridView.DataSource = typeof(IPayment);
                PaymentGridView.DataSource = _paymentViewController.CurrentSale.Payments;
            }
        }

        //to get selected payment from PaymentGridView
        private IPayment getSelectedPayment()
        {
            IPayment selectedPayment = null;

            if (PaymentGridView.SelectedCells.Count != 0)
            {
                // getting data from a selected row of datagridview
                selectedPayment = (IPayment)PaymentGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                throw new NullReferenceException("Payment should be done first!");
            }
            return selectedPayment;
        }

        private void btnKeypadRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPayment = getSelectedPayment();
                var paymentId = selectedPayment.Id;
                var paymentRemoved = _paymentViewController.RemovePayment(paymentId);
                UpdateView();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
