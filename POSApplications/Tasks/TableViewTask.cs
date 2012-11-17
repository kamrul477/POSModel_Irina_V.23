using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;
using POSModel;
using POSApplications.Tasks;
using POSApplication.Tasks;

namespace Controller
{
    public class TableViewTask: POSBaseTask
    {
        [InteractionPoint(typeof(TableViewController), IsCommonTarget = true)]
        public const string Tables = "Tables";

        internal IEmployee CurrentEmployee;
        internal ITable CurrentTable;
        internal ISale CurrentSale;
        internal bool wantToMoveTable { get; set; }

        public override void OnStart(object param)
        {
            var employeeId = new Guid((param as object[])[0].ToString());
            CurrentEmployee = System.GetEmployee(Company.Id, employeeId);

            if ((param as object[]).Count() > 1)
            {
                var tableId = new Guid((param as object[])[1].ToString());
                var tableAreaId = new Guid((param as object[])[2].ToString());

                if ((param as object[]).Count() > 3) 
                {
                    var currentSaleId = new Guid((param as object[])[3].ToString());
                }
                
                if ((param as object[]).Count() > 4) 
                {
                    wantToMoveTable = (bool)((param as object[])[4] as bool?);
                }
               

                CurrentTable =  System.GetTable(Company.Id, Store.Id, tableAreaId, tableId);
            }

            Navigator.ActivateView(Tables);
        }

        public void ReturnToMain()
        {
            //this.TasksManager.StartTask(typeof(Task name for login view));
            // Dispose the view present
        }

        public void AddCovers()
        {
            // Navigator.ViewsManager.GetView("Tables") as Tables
        }

        public IArea GetTerminalArea()
        {
            return System.GetTerminalArea(Terminal.Id);
        }

        public IEnumerable<IArea> GetAreasOFStore()
        {
            return System.GetAreasOFStore(Company.Id, Store.Id);
        }

        public IEnumerable<ITable> GetTablesInArea(Guid areaId)
        {
            return System.GetTablesInArea(Company.Id, Store.Id, areaId);
        }

        public void OpenTable(Guid tableId, Guid tableAreaId)
        {
            System.OpenTable(Company.Id, Store.Id, tableAreaId, tableId);
        }
        public void CloseTable(Guid tableId, Guid tableAreaId)
        {
            System.CloseTable(Company.Id, Store.Id, tableAreaId, tableId);
        }
        public ISale MoveSaleFromTable(Guid tableId, Guid tableAreaId)
        {
            return System.MoveSaleFromTable(Company.Id, Store.Id, TerminalArea.Id, tableAreaId, Terminal.Id, tableId);
        }
        public void MoveSaleToTable(Guid tableId, Guid tableAreaId, Guid saleId)
        {
            System.MoveSaleToTable(Company.Id, Store.Id, TerminalArea.Id, tableAreaId, Terminal.Id, tableId, saleId);
        }

        internal ITable GetTable()
        {
            return CurrentTable;
        }

        internal IArea GetTableArea(ITable table)
        {
            return table.Area;
        }

        internal void ActivateLoginView()
        {
            System.Dispose();
            this.TasksManager.StartTask(typeof(LoginTask));
        }

        internal void ActivateCoversView(ITable table)
        {
            System.Dispose();
            this.TasksManager.StartTask(typeof(DefineCoversTask), new object[] { CurrentEmployee.Id,table.Id,table.Area.Id });
        }

        internal void ActivateSalesView(ITable table)
        {
            var currentSaleId = table.CurrentSaleOnTable.Id;
            System.Dispose();
            this.TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id, table.Id, table.Area.Id,currentSaleId });
        }
        internal void ActivateSalesForTakeAway() 
        {
            var takeAwaySale = System.TakeAwaySale(Company.Id, CurrentEmployee.Id, Store.Id, Terminal.Id, TerminalArea.Id);
            this.TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id,takeAwaySale.Id });
        }
    }
}
