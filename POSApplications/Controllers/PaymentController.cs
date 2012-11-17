using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using POSApplication.Tasks;
using POSModel;
using POSApplication.IViews;

namespace POSApplication.Controllers
{
	public  class PaymentController : ControllerBase
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
                (View as IPaymentView).UpdateView();
            }
        }

        private PaymentTask _paymentTask
        {
            get            
            {
                return (Task as PaymentTask);
            }
        }

        public IEmployee CurrentEmployee { get { return _paymentTask.CurrentEmployee; } }
        public ISale CurrentSale { get { return _paymentTask.CurrentSale; } }

        public string GetDate()
        {
            DateTime date = DateTime.Now;
            return date.ToShortDateString();
        }

        public bool AddCashPayment(decimal amount) 
        {
           return  _paymentTask.AddCashPayment(amount); 
        }

        public bool AddEftposPayment(decimal amount) 
        {
           return  _paymentTask.AddEftposPayment(amount);
        }

        public decimal GetSaleTotalPaid()
        {
           return _paymentTask.GetSaleTotalPaid();
        }

        public decimal GetSaleTotalPrice()
        {
            return _paymentTask.GetSaleTotalPrice();
        }

        public decimal GetSaleChange()
        {
            return _paymentTask.GetSaleChange();
        }

        public bool FinaliseSale(decimal change)
        {
            return _paymentTask.FinaliseSale(change);
        }

        public void ActivateSaleTask()
        {
            _paymentTask.ActivateSaleView();
        }

        public void ActivateLoginTask()
        {
            _paymentTask.ActivateLoginView();
        }

        public bool RemovePayment(Guid paymentId)
        {
            return _paymentTask.RemovePayment(paymentId);
        }

        public void PrintInvoice(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            _paymentTask.PrintInvoice(sender,e);
        }
    }
}
