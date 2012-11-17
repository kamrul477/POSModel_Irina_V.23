using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel;

namespace Controller
{
    public interface ITables
    {
        void UpdateView(ITable table);

        void SetViewForMoveTable(ITable table);
    }
}
