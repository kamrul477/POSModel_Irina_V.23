using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    partial class MenuProductTemperal: IMenuProductTemperal
    {
        private MenuProductTemperal() { }

        public MenuProductTemperal(Guid menuProductId, decimal price, DateTime effectiveDate)
        {
            MenuProductId = menuProductId;
           // DateTime effectiveFrom = DateTime.Now;
            Price = price;
            EffectiveFrom = effectiveDate;
        }


    }
}
