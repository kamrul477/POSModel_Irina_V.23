using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using System.Configuration;
using System.Configuration.Assemblies;
using MVCSharp.Winforms;
using MVCSharp.Winforms.Configuration;
using POSModel;
using System.Reflection;
using POSManager;

namespace POSView
{
    [WinformsView(typeof(TableViewTask), TableViewTask.Tables)]
    public partial class Table : WinFormView, ITables
    {
        private Button btnTableToBeMoved;

        public Table()
        {
            InitializeComponent();
            //var x = ConfigurationSettings.AppSettings.Get(0);
            MdiParent = MDIManager.MDIParent;
            this.Dock = DockStyle.Fill;

            btnMoveTable.Tag = new Action<object>(setButtonsForTableToBeMoved);
            btnOpenTable.Tag = new Action<object>(setButtonsForOpenTable);
            btnCloseTable.Tag = new Action<object>(setButtonsForCloseTable);
        }

        public TableViewController _Controller
        {
            get { return Controller as TableViewController; }
        }

        public void UpdateView(ITable table)
        {

            var storeAreas = _Controller.GetAreasOFStore();
            if (cbxArea.Items.Count == 0)
            {
                cbxArea.Items.AddRange(storeAreas.ToArray());
            }
            lblEmployeeName.Text = _Controller.GetCurrentEmployeeName();

            // i can put terminal id and store id and company id in the view if i want eh :P :)
            if (table == null)
            {
                var terminalArea = _Controller.GetTerminalArea();
                cbxArea.SelectedIndex = selectedIndex(terminalArea);
                var tablesinArea = _Controller.GetTablesInArea(terminalArea.Id);
                populateTablesOfSelectdArea(tablesinArea);
            }
            else
            {
                var tableArea = _Controller.GetTableArea(table);
                cbxArea.SelectedIndex = selectedIndex(tableArea);
                var tablesinArea = _Controller.GetTablesInArea(tableArea.Id);
                populateTablesOfSelectdArea(tablesinArea);
            }
        }

        private void populateTablesOfSelectdArea(IEnumerable<ITable> tablesinArea)
        {

            if (tablesinArea != null)
            {
                flPnlTables.Controls.Clear();

                foreach (var table in tablesinArea)
                {
                    var button = new Button();
                    loadButton(table, button);
                }
            }
            else
                throw new Exception("There are No Tables in selected Area, Please Select another Area");
        }

        private void loadButton(ITable table, Button button)
        {
            button.BackColor = table.StateColor;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            button.Location = new System.Drawing.Point(3, 3);
            button.Name = "TableButton";
            button.Size = new System.Drawing.Size(195, 130);
            button.TabIndex = 0;
            button.Text = table.Description;
            button.Tag = table;
            button.UseVisualStyleBackColor = false;
            button.Click += new System.EventHandler(this.btnTable_Click);
            flPnlTables.Controls.Add(button);
            flPnlTables.Visible = true;
            if (button.BackColor.Name.Equals(Color.Gray.Name))
            {
                button.Enabled = false;
            }
        }

        private int selectedIndex(IArea area)
        {
            var selectedIndex = -1;
            foreach (var item in cbxArea.Items)
            {
                if ((item as IArea).Id.Equals(area.Id))
                {
                    selectedIndex = cbxArea.Items.IndexOf(item);
                    break;
                }
            }
            return selectedIndex;
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

            var cbxArea = sender as ComboBox;
            var actionToInvoke = cbxArea.Tag as Action<object, EventArgs>;
            if (actionToInvoke != null)
            {
                actionToInvoke.Invoke(sender, e);
            }
            else
            {
                flPnlTables.Controls.Clear();
                var area = (cbxArea.SelectedItem as IArea);
                var tablesinArea = _Controller.GetTablesInArea(area.Id);
                populateTablesOfSelectdArea(tablesinArea);
            }
        }

        private void btnTableState_Click(object sender, EventArgs e)
        {
            //var table = sender as ITable;
            //var tableArea = cbxArea.SelectedItem as IArea;
            // disable closetable,movetable,takeaway sale and cbxarea on say open table is clicked

            //switch ((sender as Button).Text) 
            //{
            //    case "OpenTable":
            //        setButtonsForOpenTable(sender);
            //        break;
            //    case "CloseTable":
            //        setButtonsForCloseTable(sender);
            //        break;
            //    case "MoveTable":
            //        setButtonsForTableToBeMoved(sender);
            //        break;
            //    default:
            //        throw new Exception("Invalid button Pressed");
            //}

            var button = sender as Button;
            var actionToInvoke = button.Tag as Action<object>;
            if (actionToInvoke != null)
            {
                actionToInvoke.Invoke(sender);
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            var table = (sender as Button).Tag as ITable;
            if (table.StateColor.Name.Equals(Color.Green.Name))
            {
                (_Controller as TableViewController).ActivateCoversView(table);
                this.Dispose();
            }
            else
            {
                (_Controller as TableViewController).ActivateSalesView(table);
            }
        }


        #region OpenTable

        private void setButtonsForOpenTable(object sender)
        {
            // open table
            var btnClicked = (sender as Button);
            btnClicked.Click -= btnTableState_Click;
            btnClicked.Click += btnStateCancel_Click;

            foreach (var button in flPnlTables.Controls)
            {
                var table = (button as Button).Tag as ITable;

                switch (table.StateColor.Name)
                {
                    case "Green":
                        (button as Button).Enabled = false;
                        break;
                    case "Gray":
                        (button as Button).Click -= btnTable_Click;
                        (button as Button).Click += btnTableSettingItsStateToOpen_Click;
                        (button as Button).Enabled = true;
                        break;
                    case "Orange":
                        (button as Button).Enabled = false;
                        break;
                    default:
                        break;
                }
            }

            btnCloseTable.Enabled = false;
            btnMoveTable.Enabled = false;
            btnTakeAway.Enabled = false;
            btnReturn.Enabled = false;
            cbxArea.Enabled = false;
        }

        private void btnTableSettingItsStateToOpen_Click(object sender, EventArgs e)
        {
            Button tableButton = sender as Button;
            ITable table = (tableButton.Tag as ITable);
            _Controller.OpenTable(table.Id, (cbxArea.SelectedItem as IArea).Id);
            btnOpenTable.Click -= btnStateCancel_Click;
            btnOpenTable.Click += btnTableState_Click;
            tableButton.Click -= btnTableSettingItsStateToOpen_Click;
            tableButton.Click += btnTable_Click;
            EnableAllControls();
            UpdateView(table);
        }

        // <----------------------------------------->

        #endregion

        #region CloseTable

        private void setButtonsForCloseTable(object sender)
        {
            var btnClicked = (sender as Button);
            btnClicked.Click -= btnTableState_Click;
            btnClicked.Click += btnStateCancel_Click;

            foreach (var button in flPnlTables.Controls)
            {
                var table = (button as Button).Tag as ITable;

                switch (table.StateColor.Name)
                {
                    case "Green":
                        (button as Button).Click -= btnTable_Click;
                        (button as Button).Click += btnTableSettingItsStateToClose_Click;
                        break;
                    case "Gray":
                        (button as Button).Enabled = false;
                        break;
                    case "Orange":
                        (button as Button).Enabled = false;
                        break;
                    default:
                        break;
                }
            }

            btnOpenTable.Enabled = false;
            btnMoveTable.Enabled = false;
            btnTakeAway.Enabled = false;
            btnReturn.Enabled = false;
            cbxArea.Enabled = false;
        }

        private void btnTableSettingItsStateToClose_Click(object sender, EventArgs e)
        {
            Button tableButton = sender as Button;
            ITable table = (tableButton.Tag as ITable);
            _Controller.CloseTable(table.Id, (cbxArea.SelectedItem as IArea).Id);
            btnCloseTable.Click -= btnStateCancel_Click;
            btnCloseTable.Click += btnTableState_Click;
            tableButton.Click -= btnTableSettingItsStateToClose_Click;
            tableButton.Click += btnTable_Click;
            EnableAllControls();
            UpdateView(table);
        }

        // <----------------------------------------->

        #endregion

        #region MoveTable
        private void setButtonsForTableToBeMoved(object sender)
        {
            var btnMove = (sender as Button);
            btnMove.Click -= btnTableState_Click;
            btnMove.Click += btnMoveStateCancel_Click;

            foreach (var button in flPnlTables.Controls)
            {
                var table = (button as Button).Tag as ITable;

                switch (table.StateColor.Name)
                {
                    case "Green":
                        (button as Button).Enabled = false;
                        break;
                    case "Gray":
                        (button as Button).Enabled = false;
                        break;
                    case "Orange":
                        (button as Button).Click -= btnTable_Click;
                        (button as Button).Click += btnTableToBeMoved_Click;
                        break;
                    default:
                        break;
                }
            }

            btnOpenTable.Enabled = false;
            btnCloseTable.Enabled = false;
            btnTakeAway.Enabled = false;
            btnReturn.Enabled = false;
            cbxArea.Tag = new Action<object, EventArgs>(cbxArea_SelectedIndexChangedAfterMoveTableClicked);
        }

        private void setButtonsForTableToMoveTo()
        {
            foreach (var button in flPnlTables.Controls)
            {
                var table = (button as Button).Tag as ITable;

                switch (table.StateColor.Name)
                {
                    case "Green":
                        (button as Button).Enabled = true;
                        (button as Button).Click -= btnTable_Click;
                        (button as Button).Click += btnTableToMoveSaleTo_Click;
                        break;
                    case "Gray":
                        (button as Button).Enabled = false;
                        break;
                    case "Orange":
                        (button as Button).Enabled = false;
                        (button as Button).Click -= btnTableToBeMoved_Click;
                        (button as Button).Click += btnTable_Click;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnTableToBeMoved_Click(object sender, EventArgs e)
        {
            btnTableToBeMoved = sender as Button;
            cbxArea.Tag = new Action<object, EventArgs>(cbxArea_SelectedIndexChangedAfterTableToBeMovedClicked);
            setButtonsForTableToMoveTo();

        }
        private void btnTableToMoveSaleTo_Click(object sender, EventArgs e)
        {
            var tableToMoveSaleto = (sender as Button).Tag as ITable;
            var sale = _Controller.MoveSaleFromTable((btnTableToBeMoved.Tag as ITable).Id, (btnTableToBeMoved.Tag as ITable).Area.Id);
            _Controller.MoveSaleToTable(tableToMoveSaleto.Id, (cbxArea.SelectedItem as IArea).Id, sale.Id);
            btnMoveTable.Click -= btnMoveStateCancel_Click;
            btnMoveTable.Click += btnTableState_Click;
            EnableAllControls();
            UpdateView((sender as Button).Tag as ITable);
            if (_Controller.wantToMoveTable) 
            {
                _Controller.ActivateSalesView((sender as Button).Tag as ITable);
            }
        }

        private void cbxArea_SelectedIndexChangedAfterMoveTableClicked(object sender, EventArgs e)
        {
            var area = (cbxArea.SelectedItem as IArea);
            var tablesinArea = _Controller.GetTablesInArea(area.Id);
            populateTablesOfSelectdArea(tablesinArea);

            foreach (var button in flPnlTables.Controls)
            {
                var table = (button as Button).Tag as ITable;

                switch (table.StateColor.Name)
                {
                    case "Green":
                        (button as Button).Enabled = false;
                        break;
                    case "Gray":
                        (button as Button).Enabled = false;
                        break;
                    case "Orange":
                        (button as Button).Click -= btnTable_Click;
                        (button as Button).Click += btnTableToBeMoved_Click;
                        break;
                    default:
                        break;
                }
            }
        }

        private void cbxArea_SelectedIndexChangedAfterTableToBeMovedClicked(object sender, EventArgs e)
        {
            var area = (cbxArea.SelectedItem as IArea);
            var tablesinArea = _Controller.GetTablesInArea(area.Id);
            populateTablesOfSelectdArea(tablesinArea);

            setButtonsForTableToMoveTo();
        }

        private void btnMoveStateCancel_Click(object sender, EventArgs e)
        {
            var btnClicked = (sender as Button);
            btnClicked.Click -= btnMoveStateCancel_Click;
            btnClicked.Click += btnTableState_Click;

            foreach (var button in flPnlTables.Controls)
            {
                RemoveClickEvents(button);

                if ((button as Button).BackColor.Name.Equals(Color.Gray.Name))
                {
                    (button as Button).Enabled = false;
                }
                else
                {
                    (button as Button).Enabled = true;
                }
                (button as Button).Click += btnTable_Click;
            }

            EnableAllControls();
        }
        // <-----------------------------------------> 
        #endregion


        private void btnStateCancel_Click(object sender, EventArgs e)
        {
            var btnClicked = (sender as Button);
            btnClicked.Click -= btnStateCancel_Click;
            btnClicked.Click += btnTableState_Click;

            foreach (var button in flPnlTables.Controls)
            {
                if ((button as Button).BackColor.Name.Equals(Color.Gray.Name))
                {
                    (button as Button).Enabled = false;
                }
                else
                {
                    (button as Button).Enabled = true;
                }

                //(button as Button).Click -= btnTableSettingItsStateToClose_Click;
                //(button as Button).Click -= btnTableSettingItsStateToOpen_Click;
                //(button as Button).Click += btnTable_Click;

                RemoveClickEvents(button);

                (button as Button).Click += btnTable_Click;
            }
            EnableAllControls();
        }

        private void RemoveClickEvents(object button)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
            BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(button as Button);
            PropertyInfo pi = (button as Button).GetType().GetProperty("Events",
            BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue((button as Button), null);
            list.RemoveHandler(obj, list[obj]);
        }
        private void EnableAllControls()
        {
            btnOpenTable.Enabled = true;
            btnCloseTable.Enabled = true;
            btnMoveTable.Enabled = true;
            btnTakeAway.Enabled = true;
            cbxArea.Enabled = true;
            btnReturn.Enabled = true;
            cbxArea.Tag = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _Controller.ActivateLoginView();
        }



        public void SetViewForMoveTable(ITable table)
        {
            setButtonsForTableToBeMoved(btnMoveTable);

            foreach (var button in flPnlTables.Controls)
            {
                var btn = button as Button;
                if ((btn.Tag as ITable).Equals(table))
                {
                    btnTableToBeMoved_Click(btn, new EventArgs());
                    break;
                }
            }
        }



        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            _Controller.ActivateSalesForTakeAway();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();       
        }
    }
}
