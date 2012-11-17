using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class Area : IArea
    {
        private Area() { }

        public Area(string description, Store store)
        {
            Description = description;
            Store = store;
        }

        public ICompany GetCompany()
        {
            return (Store.GetCompany() as ICompany);
        }

        public IStore GetStore()
        {
            return (Store as IStore);
        }

        public Table AddTable(string description)
        {
            var table = new Table(description, this);
            Tables.Add(table);
            return table;
        }

        #region Sale

        public Sale CreateANewSale(Employee employee, Table table, Guid terminalId, int covers)
        {
            var terminal = getTerminal(terminalId);
            return terminal.AddSale(employee, table, covers);
        }

        public SaleLineItem AddSaleLineItem(Employee employee, Guid saleId, MenuProduct menuProduct, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.AddSaleLineItem(employee, saleId, menuProduct);
        }

        public bool RemoveSaleLineItem(Employee employee, Guid saleId, MenuProduct menuProduct, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.RemoveSaleLineItem(employee, saleId, menuProduct);
        }

        public void IncrementQty(Employee employee, Guid saleId, MenuProduct menuProduct, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            terminal.IncrementQty(employee, saleId, menuProduct);
        }

        public void DecrementQty(Employee employee, Guid saleId, MenuProduct menuProduct, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            terminal.DecrementQty(employee, saleId, menuProduct);
        }

        public void ChangeQty(Employee employee, Guid saleId, MenuProduct menuProduct, Guid terminalId, int qty)
        {
            var terminal = getTerminal(terminalId);
            terminal.ChangeQty(employee, saleId, menuProduct, qty);
        }

        public bool RemoveSale(Employee employee, Guid saleId, Guid tableId, Guid terminalId)
        {
            removeSaleFromTheTable(tableId, saleId);
            var terminal = getTerminal(terminalId);
            return terminal.RemoveSale(employee, saleId);
        }
        
        private void removeSaleFromTheTable(Guid tableId, Guid saleId)
        {
            var table = this[tableId];
            var sale = table.GetSaleById(saleId); 
            table.RemoveSaleFromTheTable(sale);
        }

        public void ChangeCovers(Guid terminalId, Guid saleId, int covers, Employee employee)
        {
            var terminal = getTerminal(terminalId);
            terminal.ChangeCovers(saleId, covers, employee);
        }

        public bool AddCashPayment(Guid saleId, decimal amount, Employee employee, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.AddCashPayment(employee, saleId, amount);
        }

        public bool AddEftposPayment(Guid saleId, decimal amount, Employee employee, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.AddEftposPayment(employee, saleId, amount);
        }

        public bool RemovePayment(Guid saleId, Guid paymentId, Employee employee, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.RemovePayment(saleId, paymentId, employee);
        }

        public Sale TakeAwaySale(Employee employee, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.TakeAwaySale(employee);
        }

        public Sale MoveSaleFromTable(Table table, Guid terminalId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.MoveSaleFromTable(table);

        }

        public void MoveSaletoTable(Table table, Guid terminalId, Guid saleId)
        {
            var terminal = getTerminal(terminalId);
            terminal.MoveSaleToTable(table, saleId);
        }

        //public Sale MoveTable(Guid tableId)
        //{
        //    // problem with table as it may not exits in the area where there is terminal 
        //    // so probably the area which contains the table shuld create table.
        //}

        public Sale GetCurrentSaleOnTable(Guid tableId)
        {
            var table = this[tableId];
            return table.CurrentSaleOnTable;            
        }

        //public void SetSaleOnTable(Guid tableId, Sale sale)
        //{
        //    var table = this[tableId];
        //    table.CurrentSaleOnTable = sale;
        //}
        #endregion


        public void OpenTable(Guid tableId)
        {
            var table = this[tableId];
            table.OpenTable();
        }
        public void CloseTable(Guid tableId)
        {
            var table = this[tableId];
            table.CloseTable();
        }

        Guid IArea.Id
        {
            get { return Id; }
        }

        string IArea.Description
        {
            get { return Description; }
        }

        private Table this[Guid tableId]
        {
            get
            {
                return (from t in Tables where t.Id == tableId select t).First();
            }
        }

        private Terminal getTerminal(Guid tId)
        {
            return Terminals.First(ter => ter.Id == tId);
        }

        public Table GetTable(Guid tableId)
        {
            var table = this[tableId];
            return table;
        }

        public Sale GetSale(Guid terminalId, Guid saleId)
        {
            var terminal = getTerminal(terminalId);
            return terminal.GetSaleById(saleId);
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
