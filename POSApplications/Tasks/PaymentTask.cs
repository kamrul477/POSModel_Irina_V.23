using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;
using POSApplication.Controllers;
using POSModel;
using MVCSharp.Core;
using POSApplication.Tasks;
using POSApplications.Tasks;
using Controller;
using System.Drawing.Printing;
using System.Drawing;

namespace POSApplication.Tasks
{
    //public  class PaymentTask: POSBaseTask
    //{

    //    [InteractionPoint(typeof(PaymentController), IsCommonTarget = true)]
    //    public const string PaymentView = "PaymentView";
        
    //    internal ISale CurrentSale { get; set; }
    //    internal ITable CurrentTable { get; set; }
    //    internal IEmployee  CurrentEmployee { get; set; }

    //    public override void OnStart(object param)
    //    {
    //        var currentTableId = new Guid((param as object[])[0].ToString());
    //        var currentEmployeeId = new Guid((param as object[])[1].ToString());
    //        var currentSaleId = new Guid((param as object[])[2].ToString());
    //        var currentTableAreaId = new Guid((param as object[])[3].ToString());

    //        CurrentEmployee = System.GetEmployee(Company.Id, currentEmployeeId);
    //        CurrentTable = System.GetTable(Company.Id, Store.Id, currentTableAreaId, currentTableId);
    //        CurrentSale = System.GetSale(Company.Id, Store.Id, Terminal.Id, TerminalArea.Id, currentSaleId);
    //        Navigator.ActivateView(PaymentView);
    //    }

    //    public bool AddCashPayment(decimal amount) 
    //    {
    //        return System.AddCashPayment(Company.Id, Store.Id, CurrentSale.Id, amount, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id);
    //    }

    //    public bool AddEftposPayment(decimal amount) 
    //    {
    //        return System.AddEftposPayment(Company.Id, Store.Id, CurrentSale.Id, amount, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id); 
    //    }

    //    public decimal GetSaleTotalPaid() 
    //    {
    //        return CurrentSale.Total;
    //    }

    //    public decimal GetSaleTotalPrice() 
    //    {
    //        return CurrentSale.TotalPayment;
    //    }

    //    public decimal GetSaleChange()
    //    {
    //        return CurrentSale.Change;
    //    }

    //    public void FinaliseSale(decimal change)
    //    {
    //        if (GetSaleTotalPaid() >= GetSaleTotalPrice())
    //        {
    //            TasksManager.StartTask(typeof(TableViewTask), new object[] { CurrentEmployee.Id });
    //        }
    //    }

    //    public bool RemovePayment(Guid paymentId)
    //    {
    //        return System.RemovePayment(Company.Id, Store.Id, CurrentSale.Id, paymentId, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id);
    //    }

    //    public void ActivateSaleView()
    //    {
    //        using (System)
    //        {
    //            TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, CurrentSale.Id });
    //        }
    //    }

    //    public void ActivateLoginView()
    //    {
    //        using (System)
    //        {
    //            TasksManager.StartTask(typeof(LoginTask));
    //        }
    //    }
    //}
    public class PaymentTask : POSBaseTask
    {

        [InteractionPoint(typeof(PaymentController), IsCommonTarget = true)]
        public const string PaymentView = "PaymentView";

        internal ISale CurrentSale { get; set; }
        internal ITable CurrentTable { get; set; }
        internal IEmployee CurrentEmployee { get; set; }

        //TODO: kamrul have to fix this on the next version ie24
        public override void OnStart(object param)
        {
            if ((param as object[]).Count()==2)
            {
                var currentEmployeeId = new Guid((param as object[])[0].ToString());
                var currentSaleId =     new Guid((param as object[])[1].ToString());

                CurrentEmployee = System.GetEmployee(Company.Id, currentEmployeeId);
                CurrentSale = System.GetSale(Company.Id, Store.Id, Terminal.Id, TerminalArea.Id, currentSaleId);
                Navigator.ActivateView(PaymentView);
            }
            else
            {
                var currentEmployeeId = new Guid((param as object[])[0].ToString());
                var currentTableId = new Guid((param as object[])[1].ToString());
                var currentTableAreaId = new Guid((param as object[])[2].ToString());
                var currentSaleId = new Guid((param as object[])[3].ToString());
                CurrentEmployee = System.GetEmployee(Company.Id, currentEmployeeId);
                CurrentTable = System.GetTable(Company.Id, Store.Id, currentTableAreaId, currentTableId);
                CurrentSale = System.GetSale(Company.Id, Store.Id, Terminal.Id, TerminalArea.Id, currentSaleId);
                Navigator.ActivateView(PaymentView);
            }
        }

        public bool AddCashPayment(decimal amount)
        {
            return System.AddCashPayment(Company.Id, Store.Id, CurrentSale.Id, amount, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id);
        }

        public bool AddEftposPayment(decimal amount)
        {
            return System.AddEftposPayment(Company.Id, Store.Id, CurrentSale.Id, amount, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id);
        }

        public decimal GetSaleTotalPaid()
        {
            return CurrentSale.TotalPayment;
        }

        public decimal GetSaleTotalPrice()
        {
            return CurrentSale.Total;
        }

        public decimal GetSaleChange()
        {
            return CurrentSale.Change;
        }

        //TODO: kamrul have to fix this on the next version ie24
        public bool FinaliseSale(decimal change)
        {
            var canFinalise = CurrentSale.CanFinalisePayment();
            if (canFinalise)
            {
                System.SaveChanges();
                System.Dispose();
                TasksManager.StartTask(typeof(TableViewTask), new object[] { CurrentEmployee.Id });
            }
            return canFinalise;
        }

        internal void PrintInvoice(object sender, PrintPageEventArgs e)
        {
            var graphic = e.Graphics;

            var font = new Font("Courier new", 12);

            var fontHeight = font.GetHeight();
            var solidBrush = new SolidBrush(Color.Black);


            int startX = 150;
            int startY = 150;
            int offset = 230;

            var table =  (CurrentTable == null) ? "Take Away" : CurrentTable.Description;

            graphic.DrawString("Ultimo's", new Font("Courier new", 18), solidBrush, startX + 100, startY);
            graphic.DrawString("1/5 Mary Ann Street", font, solidBrush, startX + 100, startY + 40);
            graphic.DrawString("Ultimo, NSW 2000", font, solidBrush, startX + 100, startY + 70);
            graphic.DrawString("ABN:" + Company.ABN.ToString(), font, solidBrush, startX, startY + 100);
            graphic.DrawString("Table:" + table, font, solidBrush, startX, startY + 130);
            graphic.DrawString("Date:" + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortTimeString(), font, solidBrush, startX, startY + 160);
            graphic.DrawString("Description".PadRight(20) + "Price/U".PadRight(8) + "Qty".PadRight(5) + "Total", font, solidBrush, startX, startY + 190);
            graphic.DrawString("----------------------------------------", font, solidBrush, startX, startY + 210);
            foreach (var sli in CurrentSale.SaleLineItems)
            {
                var description = sli.ItemDescription.PadRight(20);
                var unitPrice = string.Format("{0:c}", sli.EachPrice).PadRight(8);
                var qty = string.Format("{0}", sli.SLIQuantity).PadRight(5);
                var total = string.Format("{0:c}", sli.Total);

                graphic.DrawString(description + unitPrice + qty + total, font, solidBrush, startX, startY + offset);
                offset += (int)fontHeight + 5;
            }
            graphic.DrawString("-----------------------------------------", font, solidBrush, startX, startY + offset);
            graphic.DrawString("Total:".PadRight(4) + string.Format("{0:c}", CurrentSale.Total), font, solidBrush, startX, startY + offset + 30);
            graphic.DrawString("Paid:".PadRight(4) + string.Format("{0:c}", CurrentSale.TotalPayment), font, solidBrush, startX, startY + offset + 50);
            graphic.DrawString("Change:".PadRight(4) +string.Format("{0:c}", CurrentSale.Change), font, solidBrush, startX, startY + offset + 70);
            graphic.DrawString("THANK YOU AND COME AGAIN", font, solidBrush, startX + 100, startY + offset + 90);
        }

        public bool RemovePayment(Guid paymentId)
        {
            return System.RemovePayment(Company.Id, Store.Id, CurrentSale.Id, paymentId, CurrentEmployee.Id, TerminalArea.Id, Terminal.Id);
        }

        public void ActivateSaleView()
        {
            using (System)
            {
                TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, CurrentSale.Id });
            }
        }

        public void ActivateLoginView()
        {
            System.Dispose();
            TasksManager.StartTask(typeof(LoginTask));
        }
    }
}
