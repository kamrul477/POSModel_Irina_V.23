using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class SaleUpdateByEmployee
    {
        private SaleUpdateByEmployee() { }

        public SaleUpdateByEmployee(Sale sale, Employee employee, string message)
        {
            Sale = sale;
            Employee = employee;
            Date = DateTime.Now;
            //will add this property to the database later :D
            Message = message;
        }
    }
}
