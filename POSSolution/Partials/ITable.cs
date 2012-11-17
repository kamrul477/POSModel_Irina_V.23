using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    public interface ITable
    {
        Guid Id { get; }
        string Description { get; }
        IEnumerable<ISale> Sales { get; }
        //ISale CurrentSale { get; }
        Color StateColor { get; }
        IArea Area { get; }
        ISale CurrentSaleOnTable { get; }
    }
}
