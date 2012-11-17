using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    public interface ISale
    {
        Guid Id { get; }
        DateTime TimeStamp { get; }
        decimal Total { get; }
        decimal GST { get; }
        decimal TotalPayment { get; }
        decimal Change { get; }
        int Covers { get; }
        IEnumerable<ISaleLineItem> SaleLineItems {get;}
        IEnumerable<IPayment> Payments { get; }
        //void ChangeCovers(int covers, IEmployee employee);

        bool CanFinalisePayment();
    }
}
