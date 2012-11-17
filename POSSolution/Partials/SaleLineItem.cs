using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSModel
{
    internal partial class SaleLineItem : ISaleLineItem
    {
        private SaleLineItem() { }

        public SaleLineItem(Sale sale, MenuProduct menuProduct)
        {
            Sale = sale;
            Quantity = 1;
            MenuProduct = menuProduct;
        }

        // ????
        public DateTime Date { get { return Sale.TimeStamp; } }

        public string ItemDescription
        {
            get
            {
                return MenuProduct.Description.TrimEnd();
            }
        }

        public int SLIQuantity
        {
            get { return this.Quantity; }
        }        

        public decimal EachPrice
        {
            get
            {
                return MenuProduct.Price;
            }
        }

        public decimal Total
        {
            get
            {
                return EachPrice * Quantity;
            }
        }

        public decimal GST
        {
            get
            {
                decimal gst = new decimal(11);
                decimal gstAmount;
                if (MenuProduct.GST_Free == false)
                {
                    gstAmount = Total / gst;
                }
                else
                {
                    gstAmount = 0;
                }

                return gstAmount;
            }
        }

        public void IncrementQty()
        {
            Quantity++;
        }

        public void DecrementQty()
        {
            if (Quantity > 1)
            {
                Quantity--;
            }
        }

        public void ChangeQty(int quantity)
        {
            Quantity = quantity;
        }
    }
}
