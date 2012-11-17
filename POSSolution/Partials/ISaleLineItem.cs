using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface ISaleLineItem
    {
        int SLIQuantity { get; }
        string ItemDescription { get; }
        decimal EachPrice { get; }
        decimal Total { get; }
        decimal GST { get; }
        Guid MenuProductId { get; }
    }
}
