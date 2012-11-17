using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class CashPayment: Payment
    {
        private CashPayment() { }

        public CashPayment(Sale sale, decimal amount) : base(sale, amount) { }

        public override string PaymentType
        {
            get
            {

                return "Cash";
            }
        }
    }
}
