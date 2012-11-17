using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCSharp;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using POSModel;

namespace Controller
{
    public class TableViewController : ControllerBase
    {
        public override IView View
        {
            get { return base.View; }
            set
            {
                base.View = value;

                (View as ITables).UpdateView(_tableViewTask.GetTable());
                if (_tableViewTask.wantToMoveTable)
                {
                    (View as ITables).SetViewForMoveTable(_tableViewTask.CurrentTable);
                }
            }
        }

        public TableViewTask _tableViewTask
        {
            get { return Task as TableViewTask; }
        }

        public IArea GetTerminalArea()
        {
            return _tableViewTask.GetTerminalArea();
        }

        public IEnumerable<IArea> GetAreasOFStore()
        {
            return _tableViewTask.GetAreasOFStore();
        }

        public IEnumerable<ITable> GetTablesInArea(Guid areaId)
        {
            return _tableViewTask.GetTablesInArea(areaId);
        }

        public string GetCurrentEmployeeName()
        {
            return _tableViewTask.CurrentEmployee.FirstName + " " + _tableViewTask.CurrentEmployee.LastName ;
        }

        public void OpenTable(Guid tableId, Guid tableAreaId)
        {
            _tableViewTask.OpenTable(tableId, tableAreaId);
        }
        public void CloseTable(Guid tableId, Guid tableAreaId)
        {
            _tableViewTask.CloseTable(tableId, tableAreaId);
        }
        public ISale MoveSaleFromTable(Guid tableId, Guid tableAreaId)
        {
            return _tableViewTask.MoveSaleFromTable(tableId, tableAreaId);
        }
        public void MoveSaleToTable(Guid tableId, Guid tableAreaId, Guid saleId)
        {
            _tableViewTask.MoveSaleToTable(tableId, tableAreaId, saleId);
        }

        public IArea GetTableArea(ITable table)
        {
            return _tableViewTask.GetTableArea(table);
        }

        public void ActivateLoginView()
        {
            _tableViewTask.ActivateLoginView();
        }

        public void ActivateCoversView(ITable table)
        {
            _tableViewTask.ActivateCoversView(table);
        }

        public void ActivateSalesView(ITable table)
        {
            _tableViewTask.ActivateSalesView(table);
        }
        public bool wantToMoveTable 
        {
            get
            {
                return _tableViewTask.wantToMoveTable;
            }
        }

        public void ActivateSalesForTakeAway()
        {

            _tableViewTask.ActivateSalesForTakeAway();
        }
    }
}
