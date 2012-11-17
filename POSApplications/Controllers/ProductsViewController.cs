using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSApplications.IViews;
using POSModel;

namespace POSApplications.Tasks
{
    public class ProductsViewController: ControllerBase
    {
        public override IView View
        {
            get
            {
                return base.View;
            }
            set
            {
                base.View = value;
                (View as IProductsView).UpdateView();
            }
        }

        public Guid CategoryId
        {
            get
            {
                return (Task as ProcessSaleTask).CategoryId;
            }
        }

        public ICategory GetCategory(Guid catId)
        {
            return (Task as ProcessSaleTask).GetCategory(catId);
        }

        public IMenuProduct[] GetCategoryMenuProducts(Guid catId)
        {
            return (Task as ProcessSaleTask).GetCategoryMenuProducts(catId);
        }

        public ISaleLineItem AddSaleLineItem(Guid menuProductId)
        {
            return (Task as ProcessSaleTask).AddSaleLineItem(menuProductId);
        }
    }
}
