using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal abstract class TableStateMachine
    {
        protected Table _Table;

        internal TableStateMachine(Table table) 
        {
            _Table = table;
        }

        internal abstract void HostSale(Action a);
        internal abstract void RemoveSale(Action a);
        internal abstract void OpenTable();
        internal abstract void CloseTable();               
    }
}
