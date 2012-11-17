using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration.Tasks;
using POSApplication.Controllers;
using System.Configuration;
using POSApplication.Tasks;
using POSModel;
using POSApplications.Tasks;
using Controller;

namespace POSApplication.Tasks
{
    public class DefineCoversTask : POSBaseTask
    {
        [InteractionPoint(typeof(CoversController), IsCommonTarget = true)]
        public const string CoversView = "CoversView";
        
        internal IEmployee CurrentEmployee { get; set; }
        internal ITable CurrentTable { get; set; }
        internal ISale CurrentSale { get; set; }
        private Guid currentTableAreaId;

        public override void OnStart(object param)
        {
            var currentEmployeeId = new Guid((param as object[])[0].ToString());
            var currentTableId = new Guid((param as object[])[1].ToString());
            currentTableAreaId = new Guid((param as object[])[2].ToString());
            
            CurrentEmployee = System.GetEmployee(Company.Id, currentEmployeeId);
            CurrentTable = System.GetTable(Company.Id, Store.Id, currentTableAreaId, currentTableId);

            if ((param as object[]).Count()>3)
            {
                var currentSaleId = new Guid((param as object[])[3].ToString());
                CurrentSale = System.GetSale(Company.Id, Store.Id, Terminal.Id, TerminalArea.Id, currentSaleId);
            }
            Navigator.ActivateView(CoversView);
        }

        public void DefineCovers(int numberOfCovers)
        {
                if (CurrentSale == null)
                {
                    CurrentSale = System.CreateNewSale(Company.Id, CurrentEmployee.Id, Store.Id,
                        CurrentTable.Area.Id, CurrentTable.Id, Terminal.Id, TerminalArea.Id, numberOfCovers); 
                }
                else
                {
                    System.ChangeCovers(Company.Id, Store.Id, TerminalArea.Id, Terminal.Id,
                        CurrentTable.CurrentSaleOnTable.Id, numberOfCovers, CurrentEmployee.Id);
                }
            
            System.Dispose();
            this.TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, currentTableAreaId, CurrentSale.Id });             
        }

        public void CancelCovers()
        {
                if (CurrentSale != null)
                {
                    System.Dispose();
                    this.TasksManager.StartTask(typeof(ProcessSaleTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, currentTableAreaId, CurrentSale.Id }); 
                }
                else if (CurrentSale == null)
                {
                    System.Dispose();
                    this.TasksManager.StartTask(typeof(TableViewTask), new object[] { CurrentEmployee.Id, CurrentTable.Id, currentTableAreaId });
                }
                        
        }    
    }
}
