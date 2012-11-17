using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Sale : ISale
    {
        private Sale() { }

        public Sale(Terminal terminal, Employee employee)
        {
            Terminal = terminal;
            TimeStamp = DateTime.Now;
            saleUpdated(employee, "Created a Take away sale");
        }

        public Sale(Terminal terminal, Table table, int covers, Employee employee)
        {
            assignToTable(table);
            Terminal = terminal;
            TimeStamp = DateTime.Now;
            Covers = covers;
            saleUpdated(employee, "Created a new Sale");
        }

        private void assignToTable(Table table)
        {
            table.HostSale(this);
        }

		Guid ISale.Id
		{
			get { return Id; }
		}

		DateTime ISale.TimeStamp
		{
			get { return TimeStamp; }
		}

        int ISale.Covers
        {
            get { return (int)Covers; }
        }

		public decimal Total
		{
			get
			{
                var total = this.SaleLineItems.Sum(s => s.Total);
                if (total >= 0)
                {
                    return total;
                }
                else
                    return 0;
			}
		}

		public decimal GST
		{
			get
			{
				return SaleLineItems.Sum(s => s.GST);
			}
		}

		public decimal TotalPayment
		{
			get
			{
                decimal pa = 0;
                if (Payments.Count != 0)
                {
                    pa = this.Payments.Sum(p => p.Amount);
                }
                return pa;
			}
		}

        public decimal Change
        {
            get
            {
                var change = TotalPayment - Total;

                return (change < 0) ? 0 : change;
            }
        }


        public SaleLineItem AddSaleLineItem(MenuProduct menuProduct, Employee employee)
        {
            SaleLineItem sli = null;
            var x = this;

            var check = from item in this.SaleLineItems where item.MenuProduct.ProductDescription == menuProduct.ProductDescription select item;
            if (check.Count() == 0)
            {
                sli = new SaleLineItem(this, menuProduct);
                this.SaleLineItems.Add(sli);
            }
            else
            {
                sli = check.First();
                check.First().Quantity++;
            }

            var message = string.Format("Added Saleline Item\nProduct:{0}\nSold @ Price:{1:c}\nQty:{2}", menuProduct.ProductDescription, sli.EachPrice, sli.Quantity);
            saleUpdated(employee, message);
            return sli;
        }

        private SaleLineItem findSaleLineItem(MenuProduct mp)
        {
            return (from item in SaleLineItems where item.MenuProduct == mp && item.SaleId == this.Id select item).First();
        }

        public bool RemoveSaleLineItem(MenuProduct menuProduct, Employee employee)
        {
            var sli = findSaleLineItem(menuProduct);
            if (sli != null)
            {
                var message = string.Format("Sale Line Item Removed\nProduct:{0}\nSold @ Price:{1:c}\nQty:{2}", menuProduct.ProductDescription, sli.EachPrice, sli.Quantity);
                saleUpdated(employee, message);
                return this.SaleLineItems.Remove(sli);
            }
            return false; 
        }

        // must to split it up for CashPayment and EftposPayment 
        public bool AddCashPayment(decimal amount, Employee employee)
        {
            bool check = canMakePayment();
            if (check == true)
            {
                var payment = new CashPayment(this, amount);
             
                Payments.Add(payment);
                var message = string.Format("CashPayment Added\nPayment Amount{0} @ Type{1}", payment.Amount,payment.PaymentType);
                saleUpdated(employee, message);
            }
            return check;
        }

        public bool AddEftposPayment(decimal amount, Employee employee)
        {
            bool check = canMakePayment();
            if (check == true)
            {
                var payment = new EftposPayment(this, amount);
                Payments.Add(payment);
                var message = string.Format("EftposPayment Added\nPayment Amount{0} @ Type{1}", payment.Amount,payment.PaymentType);
                saleUpdated(employee, message);
            }
            return check;
        }

        private bool canMakePayment()
        {
            bool payment;
            decimal dif = TotalPayment - Total;
            if (dif < 0)
            {
                payment = true;
            }
            else
            {
                payment = false;
            }
            return payment;
        }

        public bool RemovePayment(Guid paymentId, Employee employee)
        {
            if (Payments.Count != 0)
            {
                var payment = Payments.Where(p => p.Id.Equals(paymentId)).First();
                var check = Payments.Remove(payment);
                if (check == true)
                {
                    var message = string.Format("Payment Removed\nPayment Amount{0} ", payment.Amount);
                    saleUpdated(employee, message);
                }
                return check;
            }
            else return false; 
        }

        public void IncrementQty(MenuProduct menuProduct, Employee employee)
        {
            var sli = findSaleLineItem(menuProduct);
            sli.IncrementQty();
            var message = string.Format("Saleline item quantity Incremented\nProduct:{0}\nSold @ Price:{1:c}\nQty:{2}", menuProduct.ProductDescription, sli.EachPrice, sli.Quantity);
            saleUpdated(employee, message);
        }

        public void DecrementQty(MenuProduct menuProduct, Employee employee)
        {
            var sli = findSaleLineItem(menuProduct);
            sli.DecrementQty();
            var message = string.Format("Saleline item quantity Decremented\nProduct:{0}\nSold @ Price:{1:c}\nQty:{2}", menuProduct.ProductDescription, sli.EachPrice, sli.Quantity);
            saleUpdated(employee, message);
        }

        public void ChangeQty(MenuProduct menuProduct, int qty, Employee employee)
        {
            var sli = findSaleLineItem(menuProduct);
            sli.ChangeQty(qty);
            var message = string.Format("Saleline item quantity changed\nProduct:{0}\nSold @ Price:{1:c}\nQty:{2}", menuProduct.ProductDescription, sli.EachPrice, sli.Quantity);
            saleUpdated(employee, message);
        }

        public void ChangeCovers(int covers, Employee employee)
        {
            Covers = covers;
            var message = string.Format("Sale Covers changed\nCovers{0}", covers);
            saleUpdated(employee, message);
        }

        public SaleUpdateByEmployee saleUpdated(Employee employee, string message)
        {
            var saleUpdate = new SaleUpdateByEmployee(this, employee, message);
            this.SaleUpdateByEmployees.Add(saleUpdate);
            return saleUpdate;
        }

        IEnumerable<ISaleLineItem> ISale.SaleLineItems
        {
            get { return this.SaleLineItems; }
        }

        IEnumerable<IPayment> ISale.Payments
        {
            get { return this.Payments; }
        }


        public bool CanFinalisePayment()
        {
            if (canMakePayment() == false)
            {
                this.Table.OpenTable();
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
