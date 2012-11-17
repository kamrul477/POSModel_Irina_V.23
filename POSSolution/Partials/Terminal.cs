using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Terminal : ITerminal
    {
        /*private Terminal() { }

        public Terminal(Area area, string description)
        {
            this.Area = area;
            this.Description = description;
        }*/

        Guid ITerminal.Id
        {
            get { return Id; }
        }

        string ITerminal.Description
        {
            get { return Description; }
        }

        #region Sale

        public Sale AddSale(Employee employee, Table table, int covers)
        {
            var sale = new Sale(this, table, covers, employee);
            this.Sales.Add(sale);
            return sale;
        }

        internal Sale GetSaleById(Guid saleId) 
        {
            return  (from s in Sales where s.Id == saleId select s).First();
        }

        public Sale TakeAwaySale(Employee employee)
        {
            var sale = new Sale(this, employee);
            return sale;
        }

        public bool RemoveSale(Employee employee, Guid saleId)
        {
            var sale = GetSaleById(saleId);
            foreach (var sli in sale.SaleLineItems)
            {
                sale.RemoveSaleLineItem(sli.MenuProduct, employee);
            }
            sale.saleUpdated(employee, "Remove Sale");

            if (Sales.Contains(sale))
            {
                return this.Sales.Remove(sale);
            }
            else
                return false;
        }

        public SaleLineItem AddSaleLineItem(Employee employee, Guid saleId, MenuProduct menuProduct)
        {
            var sale = GetSaleById(saleId);
            var sli = sale.AddSaleLineItem(menuProduct, employee);
            return sli;
        }

        public bool RemoveSaleLineItem(Employee employee, Guid saleId, MenuProduct menuProduct)
        {
            var sale = GetSaleById(saleId);
            return sale.RemoveSaleLineItem(menuProduct, employee);
        }

        public void IncrementQty(Employee employee, Guid saleId, MenuProduct menuProduct)
        {
            var sale = GetSaleById(saleId);
            sale.IncrementQty(menuProduct, employee);
        }

        public void DecrementQty(Employee employee, Guid saleId, MenuProduct menuProduct)
        {
            var sale = GetSaleById(saleId);
            sale.DecrementQty(menuProduct, employee);
        }

        public void ChangeQty(Employee employee, Guid saleId, MenuProduct menuProduct, int qty)
        {
            var sale = GetSaleById(saleId);
            sale.ChangeQty(menuProduct, qty, employee);
        }

        public void ChangeCovers(Guid saleId, int covers, Employee employee)
        {
            var sale = GetSaleById(saleId);
            sale.ChangeCovers(covers, employee);
        }

        public bool AddCashPayment(Employee employee, Guid saleId, decimal amount)
        {
            var sale = GetSaleById(saleId);
            return sale.AddCashPayment(amount, employee);
        }

        public bool AddEftposPayment(Employee employee, Guid saleId, decimal amount)
        {
            var sale = GetSaleById(saleId);
            return sale.AddEftposPayment(amount, employee);
        }

        public bool RemovePayment(Guid saleId, Guid paymentId, Employee employee)
        {
            var sale = GetSaleById(saleId);
            return sale.RemovePayment(paymentId, employee);
        }

        public Sale MoveSaleFromTable(Table table)
        {
            var sale = table.CurrentSaleOnTable;
            table.RemoveSaleFromTheTable(sale);
            return sale;
        }
        public void MoveSaleToTable(Table table, Guid saleId)
        {
            var sale = this.Sales.First(s => s.Id.Equals(saleId));
            table.HostSale(sale);
        }

        #endregion


        IEnumerable<ISale> ITerminal.Sales
        {
            get { return Sales; }
        }

        public ICompany Company
        {
            get { return Area.GetCompany();}
        }

        public IStore Store
        {
            get { return Area.GetStore(); }
        }

        IArea ITerminal.Area
        {
            get { return Area as IArea; }
        }
    }
}
