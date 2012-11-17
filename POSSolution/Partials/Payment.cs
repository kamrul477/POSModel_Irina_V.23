using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal abstract partial class Payment: IPayment
    {
        protected Payment() { }

        public Payment(Sale sale, decimal amount)
        {
            Sale = sale;
            Amount = amount;             
        }

        public abstract string PaymentType { get; }
    }
}
