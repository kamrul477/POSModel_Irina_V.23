using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class EftposPayment : Payment
    {
        private EftposPayment() { }

        public EftposPayment(Sale sale, decimal amount) : base(sale, amount) { }

        public override string PaymentType
        {
            get
            {
                return "Eftpos";
            }
        }

    }
}
