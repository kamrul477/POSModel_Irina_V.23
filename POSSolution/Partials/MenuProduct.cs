using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSModel.Partials;

namespace POSModel
{
    internal partial class MenuProduct: IMenuProduct
    {
        private MenuProduct() { }

        public MenuProduct(Guid menuId, Guid productId)
        {
            MenuId = menuId;
            ProductId = productId;
        }

        public MenuProductTemperal CreateMenuProductTemperal(decimal price, DateTime date)
        {
            var mpt = FetchMPT(price, date);
            if (MenuProductTemperals.Contains(mpt))
            {
                throw new Exception("Existed");
            }
            mpt = new MenuProductTemperal(this.Id, price, date);
            MenuProductTemperals.Add(mpt);
            return mpt;
        }

        public decimal FetchPrice(DateTime date)
        {
            decimal price = ProductDescription.BasePrice;
            foreach (var mpt in MenuProductTemperals.OrderByDescending(mpt => mpt.EffectiveFrom))
            {
                if (date >= mpt.EffectiveFrom)
                    price = mpt.Price;
                break;
            }
            return price;
        }

        public MenuProductTemperal FetchMPT(decimal price, DateTime date)
        {
            return MenuProductTemperals.Where(mpt => mpt.Price == price && mpt.EffectiveFrom.Equals(date)).First();
        }

        public Category Category
        {
            get { return this.ProductDescription.Category; }
        }

        Guid IMenuProduct.Id
        {
            get { return Id; }
        }

        public string Description
        {
            get { return ProductDescription.Description; }
        }

        public bool GST_Free
        {
            get
            {
                return (bool)ProductDescription.Gst_Free;
            }
        }

        public decimal Price
        {
            get { return MenuProductTemperals.Last().Price ; }
        }
    }
}
