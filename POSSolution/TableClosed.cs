using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    class TableClosed : TableStateMachine
    {
        public TableClosed(Table table) : base(table) { }

        internal override void HostSale(Action a)
        {
            throw new Exception("The selected table is currently closed, please select another table to host the sale");
        }

        internal override void RemoveSale(Action a)
        {
            throw new Exception("The selected table is closed, And has no sale on it");
        }

        internal override void CloseTable()
        {
            throw new Exception("The selected table is already Closed");
        }

        internal override void OpenTable()
        {
            _Table.TableStateId = 1;
        }
    }
}
