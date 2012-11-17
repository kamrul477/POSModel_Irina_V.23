using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSModel;
using POSApplications.IViews;
using System.Drawing.Printing;

namespace POSApplications.Tasks
{
    public class SaleViewController: ControllerBase
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
                (View as ISaleView).UpdateView();
            }
        }

        private ProcessSaleTask _processSaleTask
        {
            get
            {
                return (Task as ProcessSaleTask);
            }
        }

        public IEmployee CurrentEmployee
        {
            get { return _processSaleTask.CurrentEmployee; }
        }

        public ISale CurrentSale
        {
            get { return _processSaleTask.CurrentSale; }
        }

        public ITable CurrentTable
        {
            get { return _processSaleTask.CurrentTable; }
        }

        public int CurrentCovers
        {
            get { return _processSaleTask.CurrentCovers; }
        }

        public Guid CategoryId
        {
            get
            {
                return _processSaleTask.CategoryId;
            }
        }

        public ICategory GetCategory(Guid catId)
        {
            return _processSaleTask.GetCategory(catId);
        }

        public IMenuProduct[] GetCategoryMenuProducts(Guid catId)
        {
            return _processSaleTask.GetCategoryMenuProducts(catId);
        }

        public ISaleLineItem AddSaleLineItem(Guid menuProductId)
        {
            return _processSaleTask.AddSaleLineItem(menuProductId);
        }

        public IEnumerable<ICategory> GetCategories()
        {
            return _processSaleTask.GetCategories();
        }

        public bool RemoveSaleLineItem(Guid menuProductId)
        {
            return _processSaleTask.RemoveSaleLineItem(menuProductId);
        }

        public void IncrementQty(Guid menuProductId)
        {
            _processSaleTask.IncrementQty(menuProductId);
        }

        public void DecrementQty(Guid menuProductId)
        {
            _processSaleTask.DecrementQty(menuProductId);
        }

        public bool RemoveSale()
        {
            return _processSaleTask.RemoveSale();
        }

        public void ActivateQuantityView(Guid mpId)
        {
            _processSaleTask.ActivateQuantityView(mpId);
        }

        public void BackToTableView(bool moveTable)
        {
            _processSaleTask.BackToTableView(moveTable);
        }

        public void ActivatePaymentView()
        {
            _processSaleTask.ActivatePaymentView();
        }

        public void BackToLoginView()
        {
            _processSaleTask.BackToLoginView();
        }

        public void BackToCoversView()
        {
            _processSaleTask.BackToCoversView();
        }
        public void PrintBill(object sender, PrintPageEventArgs e)
        {
            _processSaleTask.PrintBill(sender, e);
        }

        public void SendOrder(object sender, PrintPageEventArgs e)
        {
            _processSaleTask.SendOrder(sender, e);
        }
    }
}
