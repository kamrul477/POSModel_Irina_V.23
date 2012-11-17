using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core.Configuration.Tasks;
using POSModel;
using Controller;
using POSApplication.Tasks;
using System.Drawing.Printing;
using System.Drawing;


namespace POSApplications.Tasks
{
    public class ProcessSaleTask: POSBaseTask
    {
        [InteractionPoint(typeof(SaleViewController), IsCommonTarget = true)]
        public const string SaleView = "SaleView";

        [InteractionPoint(typeof(ProductsViewController), IsCommonTarget = true)]
        public const string ProductsView = "ProductsView";

        [InteractionPoint(typeof(QuantityViewController), IsCommonTarget = true)]
        public const string QuantityView = "QuantityView";

        internal IEmployee CurrentEmployee { get; set; }
        internal ISale CurrentSale { get; set; }
        internal ITable CurrentTable { get; set; }
        internal int CurrentCovers { get; set; }

        private Guid currentTableAreaId;
        

        public override void OnStart(object param)
        {
            Guid currentSaleId;
            Guid currentTableId= Guid.Empty;

            var currentEmployeeId = new Guid((param as object[])[0].ToString());

            if ((param as object[]).Count() == 4)
            {
                currentTableId = new Guid((param as object[])[1].ToString());
                currentTableAreaId = new Guid((param as object[])[2].ToString());
                currentSaleId = new Guid((param as object[])[3].ToString());

                CurrentEmployee = System.GetEmployee(Company.Id, currentEmployeeId);
                CurrentSale = System.GetSale(Company.Id, Store.Id, Terminal.Id, TerminalArea.Id, currentSaleId);
                CurrentTable = System.GetTable(Company.Id, Store.Id, currentTableAreaId, currentTableId);
                CurrentCovers = (int)(CurrentSale.Covers);
            }
            else
            {
                currentSaleId = new Guid((param as object[])[1].ToString());
            }

            base.OnStart(param);
            Navigator.ActivateView(SaleView);
        }

        public Guid CategoryId { get; set; }
        public Guid MenuProductId { get; set; }
        
        public ICategory GetCategory(Guid catId)
        {
            return System.FetchCategory(Company.Id, Store.Id, CurrentMenu.Id, catId);
        }

        public IEnumerable<ICategory> GetCategories()
        {
            return System.GetCategories(Company.Id, Store.Id, CurrentMenu.Id);          
        }

        public IMenuProduct[] GetCategoryMenuProducts(Guid catId)
        {
            return System.GetCategoryMenuProducts(Company.Id, Store.Id, CurrentMenu.Id, catId);
        }

        public ISaleLineItem AddSaleLineItem(Guid menuProductId)
        {
            var sli = System.AddSaleLineItem(Company.Id, CurrentEmployee.Id, Store.Id,
                CurrentSale.Id, CurrentMenu.Id, Terminal.Id, TerminalArea.Id, menuProductId);
            return sli;
        }

        public bool RemoveSaleLineItem(Guid menuProductId)
        {
            return System.RemoveSaleLineItem(Company.Id, CurrentEmployee.Id, Store.Id,
                CurrentSale.Id, CurrentMenu.Id, Terminal.Id, TerminalArea.Id, menuProductId);
        }

        public void IncrementQty(Guid menuProductId)
        {
            System.IncrementQty(Company.Id, CurrentEmployee.Id, Store.Id, CurrentSale.Id,
                CurrentMenu.Id, Terminal.Id, TerminalArea.Id, menuProductId);
        }

        public void DecrementQty(Guid menuProductId)
        {
            System.DecrementQty(Company.Id, CurrentEmployee.Id, Store.Id, CurrentSale.Id,
                    CurrentMenu.Id, Terminal.Id, TerminalArea.Id, menuProductId);
        }

        public void ChangeQty( Guid menuProductId, int qty)
        {
            System.ChangeQty(Company.Id, CurrentEmployee.Id, Store.Id, CurrentSale.Id,
                    CurrentMenu.Id, Terminal.Id, TerminalArea.Id, menuProductId, qty);
        }

        public bool RemoveSale()
        {
           return System.RemoveSale(Company.Id, CurrentEmployee.Id, Store.Id, CurrentSale.Id,
                CurrentTable.Id, Terminal.Id, TerminalArea.Id);
        }

        public void ActivateQuantityView(Guid mpId)
        {
            MenuProductId = mpId;
            Navigator.ActivateView(QuantityView);
        }        

        public void BackToTableView(bool moveTable)
        {
            System.Dispose();           
            this.TasksManager.StartTask(typeof(TableViewTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, currentTableAreaId, CurrentSale.Id, moveTable });
        }

        public void BackToCoversView()
        {
            System.Dispose();
            this.TasksManager.StartTask(typeof(DefineCoversTask), new object[] { CurrentEmployee.Id, CurrentTable.Id,currentTableAreaId, CurrentSale.Id }); 
        }

        public void ActivatePaymentView()
        {
            System.Dispose();
            this.TasksManager.StartTask(typeof(PaymentTask), new object[] { CurrentEmployee.Id, CurrentTable.Id,currentTableAreaId, CurrentSale.Id });
        }

        public void BackToLoginView()
        {
            System.Dispose();
            this.TasksManager.StartTask(typeof(LoginTask));
        }

        internal void PrintBill(object sender, PrintPageEventArgs e)
        {
            var graphic = e.Graphics;

            var font = new Font("Courier new", 12);

            var fontHeight = font.GetHeight();
            var solidBrush = new SolidBrush(Color.Black);


            int startX = 150;
            int startY = 150;
            int offset = 230;
            var table = (CurrentTable == null) ? "Take Away" : CurrentTable.Description;

            graphic.DrawString("Ultimo's", new Font("Courier new", 18), solidBrush, startX + 100, startY);
            graphic.DrawString("1/5 Mary Ann Street", font, solidBrush, startX + 100, startY + 40);
            graphic.DrawString("Ultimo, NSW 2000", font, solidBrush, startX + 100, startY + 70);
            graphic.DrawString("ABN:" + Company.ABN.ToString(), font, solidBrush, startX, startY + 100);
            graphic.DrawString("Table:" + table, font, solidBrush, startX, startY + 130);
            graphic.DrawString("Date:" + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortTimeString(), font, solidBrush, startX, startY + 160);
            graphic.DrawString("Description".PadRight(20) + "Price/U".PadRight(8) + "Qty".PadRight(5) + "Total", font, solidBrush, startX, startY + 190);
            graphic.DrawString("---------------------------------------------", font, solidBrush, startX, startY + 210);
            foreach (var sli in CurrentSale.SaleLineItems)
            {
                var description = sli.ItemDescription.PadRight(20);
                var unitPrice = string.Format("{0:c}", sli.EachPrice).PadRight(8);
                var qty = string.Format("{0}", sli.SLIQuantity).PadRight(5);
                var total = string.Format("{0:c}", sli.Total);

                graphic.DrawString(description + unitPrice + qty + total, font, solidBrush, startX, startY + offset);
                offset += (int)fontHeight + 5;
            }
            graphic.DrawString("----------------------------------------------", font, solidBrush, startX, startY + offset);
            graphic.DrawString("Total:" + string.Format("{0:c}", CurrentSale.Total), font, solidBrush, startX, startY + offset + 30);
            //graphic.DrawString("Paid:" + CurrentSale.TotalPayment.ToString(), font, solidBrush, startX, startY + offset + 50);
            //graphic.DrawString("Change:" + CurrentSale.Change.ToString(), font, solidBrush, startX, startY + offset + 70);
            graphic.DrawString("THANK YOU AND COME AGAIN", font, solidBrush, startX + 100, startY + offset + 90);
        }

        internal void SendOrder(object sender, PrintPageEventArgs e)
        {
            var graphic = e.Graphics;

            var font = new Font("Courier new", 12);

            var fontHeight = font.GetHeight();
            var solidBrush = new SolidBrush(Color.Black);


            int startX = 150;
            int startY = 150;
            int offset = 230;
            var table = (CurrentTable == null) ? "Take Away" : CurrentTable.Description;

            graphic.DrawString("Ultimo's", new Font("Courier new", 18), solidBrush, startX + 100, startY);
            graphic.DrawString("1/5 Mary Ann Street", font, solidBrush, startX + 100, startY + 40);
            graphic.DrawString("Ultimo, NSW 2000", font, solidBrush, startX + 100, startY + 70);
            graphic.DrawString("Table:" + table, font, solidBrush, startX, startY + 100);
            graphic.DrawString("Date:" + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortTimeString(), font, solidBrush, startX, startY + 130);
            graphic.DrawString("Description".PadRight(20) + "Qty".PadRight(5), font, solidBrush, startX, startY + 160);
            graphic.DrawString("-------------------------------", font, solidBrush, startX, startY + 190);
            foreach (var sli in CurrentSale.SaleLineItems)
            {
                var description = sli.ItemDescription.PadRight(20);
                var qty = string.Format("{0}", sli.SLIQuantity).PadRight(5);

                graphic.DrawString(description + qty, font, solidBrush, startX, startY + offset);
                offset += (int)fontHeight + 5;
            }
        }
    }
}
