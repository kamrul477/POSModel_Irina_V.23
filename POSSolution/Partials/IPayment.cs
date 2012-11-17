using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
   public interface IPayment
    {
       Guid Id { get; }
       decimal Amount { get; }

    }
}
