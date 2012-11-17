using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    internal class TableOpened : TableStateMachine
    {
        public TableOpened(Table table) : base(table) { }

        internal override void HostSale(Action a)
        {

            a();
        }

        internal override void RemoveSale(Action a)
        {
            throw new Exception("The selected table does not have a sale");
        }

        internal override void CloseTable()
        {
            _Table.TableStateId = 2;
        }

        internal override void OpenTable()
        {
            throw new Exception("The selected table is already Open");
        }
    }
}
