using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace POSModel
{
    internal partial class Table : ITable
    {
        //private Sale _currentSale;
        private TableStateMachine _state;
        //delegate void StateMessageOnSale (Object state);
        //delegate void StateMessage();


        private Table() { }

        public Table(string description, Area area)
        {
            Description = description;
            _state = new TableClosed(this);
            _state.OpenTable();
            stateColor = Color.Green;
            Area = area;
        }

        public Sale CurrentSaleOnTable
        {
            get 
            {
               return this.Sales.Last();
            }
        }
        #region State
        public void CloseTable()
        {
            _state.CloseTable();
        }
        public void OpenTable()
        {
            _state.OpenTable();
        }

        public void HostSale(Sale sale)
        {
            var action = new Action(delegate { TableStateId = 3;this.Sales.Add(sale); sale.Table = this; });
            _state.HostSale(action);
        }


        public void RemoveSaleFromTheTable(Sale sale)
        {
            var action = new Action(delegate { TableStateId = 1; ; this.Sales.Remove(sale); });
            _state.RemoveSale(action);
        }
        #endregion


        public void ChangeTableArea(Area area)
        {
            this.Area = area;
        }

        partial void OnTableStateIdChanged()
        {
            switch (this.TableStateId)
            {
                case 1:
                    _state = new TableOpened(this);
                    stateColor = Color.Green;
                    break;
                case 2:
                    _state = new TableClosed(this);
                    stateColor = Color.Gray;
                    break;
                case 3:
                    _state = new TableInUse(this);
                    stateColor = Color.Orange;
                    break;
                default:
                    throw new Exception("Invalid state");
            }
        }

        Color ITable.StateColor
        {
            get
            {
                //var x = !stateColor.Name.Equals("0");
                if (!stateColor.Name.Equals("0"))
                {
                    return stateColor;
                }
                else
                    return Color.Green;
            }
        }
        internal Color stateColor
        {
            get;
            set;
        }

        IEnumerable<ISale> ITable.Sales
        {
            get { return Sales; }
        }

        IArea ITable.Area
        {
            get
            {
                return Area;
            }
        }


        ISale ITable.CurrentSaleOnTable
        {
            get
            {
               return this.Sales.Last();
            }
        }
        public Sale GetSaleById(Guid saleId)
        {
            return Sales.First(s => s.Id == saleId);
        }



        //public ISale CurrentSale
        //{
        //    get { return CurrentSaleOnTable; }
        //}
    }
}
