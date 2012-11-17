using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal class TableInUse : TableStateMachine
    {
        public TableInUse(Table table) : base(table) { }

        internal override void HostSale(Action a)
        {
            throw new Exception("The selected table is currently in use, please select another table to host the sale");
        }

        internal override void RemoveSale(Action a)
        {
            a();
        }

        internal override void CloseTable()
        {
            throw new Exception("The selected table is currently in use, You cannot close it");
        }

        internal override void OpenTable()
        {
            _Table.TableStateId = 1;
            // i am right >:D
            /// Irina asked you to change this!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

    }
}
