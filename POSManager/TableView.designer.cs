//namespace POSView
//{
//    partial class TableView
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.gbxMainViewcontainer = new System.Windows.Forms.GroupBox();
//            this.btnLogOut = new System.Windows.Forms.Button();
//            this.label6 = new System.Windows.Forms.Label();
//            this.lblTime = new System.Windows.Forms.Label();
//            this.flPnlTables = new System.Windows.Forms.FlowLayoutPanel();
//            this.lblDate = new System.Windows.Forms.Label();
//            this.btnReturn = new System.Windows.Forms.Button();
//            this.label4 = new System.Windows.Forms.Label();
//            this.cbxArea = new System.Windows.Forms.ComboBox();
//            this.lblEmployeeName = new System.Windows.Forms.Label();
//            this.lblEmployeeIdText = new System.Windows.Forms.Label();
//            this.gbTableActionButtons = new System.Windows.Forms.GroupBox();
//            this.btnTakeAway = new System.Windows.Forms.Button();
//            this.btnMoveTable = new System.Windows.Forms.Button();
//            this.btnCloseTable = new System.Windows.Forms.Button();
//            this.btnOpenTable = new System.Windows.Forms.Button();
//            this.lblAreaText = new System.Windows.Forms.Label();
//            this.lblCompanyId = new System.Windows.Forms.Label();
//            this.lblCompanyIdText = new System.Windows.Forms.Label();
//            this.lblStoreId = new System.Windows.Forms.Label();
//            this.lblStoreNameText = new System.Windows.Forms.Label();
//            this.lblTerminalId = new System.Windows.Forms.Label();
//            this.lblTerminalIdText = new System.Windows.Forms.Label();
//            this.timer = new System.Windows.Forms.Timer(this.components);
//            this.gbxMainViewcontainer.SuspendLayout();
//            this.gbTableActionButtons.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // gbxMainViewcontainer
//            // 
//            this.gbxMainViewcontainer.Controls.Add(this.btnLogOut);
//            this.gbxMainViewcontainer.Controls.Add(this.label6);
//            this.gbxMainViewcontainer.Controls.Add(this.lblTime);
//            this.gbxMainViewcontainer.Controls.Add(this.flPnlTables);
//            this.gbxMainViewcontainer.Controls.Add(this.lblDate);
//            this.gbxMainViewcontainer.Controls.Add(this.btnReturn);
//            this.gbxMainViewcontainer.Controls.Add(this.label4);
//            this.gbxMainViewcontainer.Controls.Add(this.cbxArea);
//            this.gbxMainViewcontainer.Controls.Add(this.lblEmployeeName);
//            this.gbxMainViewcontainer.Controls.Add(this.lblEmployeeIdText);
//            this.gbxMainViewcontainer.Controls.Add(this.gbTableActionButtons);
//            this.gbxMainViewcontainer.Controls.Add(this.lblAreaText);
//            this.gbxMainViewcontainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.gbxMainViewcontainer.ForeColor = System.Drawing.Color.Black;
//            this.gbxMainViewcontainer.Location = new System.Drawing.Point(27, 22);
//            this.gbxMainViewcontainer.Name = "gbxMainViewcontainer";
//            this.gbxMainViewcontainer.Size = new System.Drawing.Size(985, 713);
//            this.gbxMainViewcontainer.TabIndex = 0;
//            this.gbxMainViewcontainer.TabStop = false;
//            this.gbxMainViewcontainer.Text = "Select Table";
//            // 
//            // btnLogOut
//            // 
//            this.btnLogOut.BackColor = System.Drawing.Color.Crimson;
//            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnLogOut.ForeColor = System.Drawing.Color.White;
//            this.btnLogOut.Location = new System.Drawing.Point(826, 649);
//            this.btnLogOut.Name = "btnLogOut";
//            this.btnLogOut.Size = new System.Drawing.Size(113, 42);
//            this.btnLogOut.TabIndex = 37;
//            this.btnLogOut.Text = "Log Out";
//            this.btnLogOut.UseVisualStyleBackColor = false;
//            this.btnLogOut.Click += new System.EventHandler(this.btnReturn_Click);
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label6.ForeColor = System.Drawing.Color.Black;
//            this.label6.Location = new System.Drawing.Point(541, 45);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(56, 20);
//            this.label6.TabIndex = 36;
//            this.label6.Text = "Time:";
//            // 
//            // lblTime
//            // 
//            this.lblTime.AutoSize = true;
//            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
//            this.lblTime.Location = new System.Drawing.Point(599, 45);
//            this.lblTime.Name = "lblTime";
//            this.lblTime.Size = new System.Drawing.Size(81, 20);
//            this.lblTime.TabIndex = 35;
//            this.lblTime.Text = "00:00:00";
//            // 
//            // flPnlTables
//            // 
//            this.flPnlTables.AutoScroll = true;
//            this.flPnlTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
//            this.flPnlTables.Location = new System.Drawing.Point(24, 254);
//            this.flPnlTables.Name = "flPnlTables";
//            this.flPnlTables.Size = new System.Drawing.Size(937, 370);
//            this.flPnlTables.TabIndex = 20;
//            // 
//            // lblDate
//            // 
//            this.lblDate.AutoSize = true;
//            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
//            this.lblDate.Location = new System.Drawing.Point(427, 46);
//            this.lblDate.Name = "lblDate";
//            this.lblDate.Size = new System.Drawing.Size(81, 20);
//            this.lblDate.TabIndex = 34;
//            this.lblDate.Text = "00/00/00";
//            // 
//            // btnReturn
//            // 
//            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
//            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//            this.btnReturn.FlatAppearance.BorderSize = 2;
//            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
//            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnReturn.ForeColor = System.Drawing.Color.Black;
//            this.btnReturn.Location = new System.Drawing.Point(1017, 883);
//            this.btnReturn.Name = "btnReturn";
//            this.btnReturn.Size = new System.Drawing.Size(168, 47);
//            this.btnReturn.TabIndex = 19;
//            this.btnReturn.Text = "Return";
//            this.btnReturn.UseVisualStyleBackColor = false;
//            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.ForeColor = System.Drawing.Color.Black;
//            this.label4.Location = new System.Drawing.Point(367, 46);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(55, 20);
//            this.label4.TabIndex = 33;
//            this.label4.Text = "Date:";
//            // 
//            // cbxArea
//            // 
//            this.cbxArea.BackColor = System.Drawing.SystemColors.Info;
//            this.cbxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cbxArea.FormattingEnabled = true;
//            this.cbxArea.Location = new System.Drawing.Point(132, 206);
//            this.cbxArea.Name = "cbxArea";
//            this.cbxArea.Size = new System.Drawing.Size(299, 24);
//            this.cbxArea.TabIndex = 18;
//            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
//            // 
//            // lblEmployeeName
//            // 
//            this.lblEmployeeName.AutoSize = true;
//            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblEmployeeName.ForeColor = System.Drawing.Color.Maroon;
//            this.lblEmployeeName.Location = new System.Drawing.Point(102, 43);
//            this.lblEmployeeName.Name = "lblEmployeeName";
//            this.lblEmployeeName.Size = new System.Drawing.Size(148, 22);
//            this.lblEmployeeName.TabIndex = 7;
//            this.lblEmployeeName.Text = "EmployeeName";
//            // 
//            // lblEmployeeIdText
//            // 
//            this.lblEmployeeIdText.AutoSize = true;
//            this.lblEmployeeIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblEmployeeIdText.ForeColor = System.Drawing.Color.Black;
//            this.lblEmployeeIdText.Location = new System.Drawing.Point(44, 43);
//            this.lblEmployeeIdText.Name = "lblEmployeeIdText";
//            this.lblEmployeeIdText.Size = new System.Drawing.Size(58, 22);
//            this.lblEmployeeIdText.TabIndex = 6;
//            this.lblEmployeeIdText.Text = "User:";
//            // 
//            // gbTableActionButtons
//            // 
//            this.gbTableActionButtons.Controls.Add(this.btnTakeAway);
//            this.gbTableActionButtons.Controls.Add(this.btnMoveTable);
//            this.gbTableActionButtons.Controls.Add(this.btnCloseTable);
//            this.gbTableActionButtons.Controls.Add(this.btnOpenTable);
//            this.gbTableActionButtons.Location = new System.Drawing.Point(27, 69);
//            this.gbTableActionButtons.Name = "gbTableActionButtons";
//            this.gbTableActionButtons.Size = new System.Drawing.Size(934, 115);
//            this.gbTableActionButtons.TabIndex = 15;
//            this.gbTableActionButtons.TabStop = false;
//            // 
//            // btnTakeAway
//            // 
//            this.btnTakeAway.BackColor = System.Drawing.Color.Navy;
//            this.btnTakeAway.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
//            this.btnTakeAway.FlatAppearance.BorderSize = 2;
//            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnTakeAway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.btnTakeAway.Location = new System.Drawing.Point(776, 36);
//            this.btnTakeAway.Name = "btnTakeAway";
//            this.btnTakeAway.Size = new System.Drawing.Size(136, 63);
//            this.btnTakeAway.TabIndex = 3;
//            this.btnTakeAway.Text = "TakeAway";
//            this.btnTakeAway.UseVisualStyleBackColor = false;
//            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
//            // 
//            // btnMoveTable
//            // 
//            this.btnMoveTable.BackColor = System.Drawing.Color.Tomato;
//            this.btnMoveTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//            this.btnMoveTable.FlatAppearance.BorderSize = 2;
//            this.btnMoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnMoveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnMoveTable.ForeColor = System.Drawing.SystemColors.ControlText;
//            this.btnMoveTable.Location = new System.Drawing.Point(346, 32);
//            this.btnMoveTable.Name = "btnMoveTable";
//            this.btnMoveTable.Size = new System.Drawing.Size(146, 67);
//            this.btnMoveTable.TabIndex = 2;
//            this.btnMoveTable.Text = "MoveTable";
//            this.btnMoveTable.UseVisualStyleBackColor = false;
//            this.btnMoveTable.Click += new System.EventHandler(this.btnTableState_Click);
//            // 
//            // btnCloseTable
//            // 
//            this.btnCloseTable.BackColor = System.Drawing.Color.Silver;
//            this.btnCloseTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//            this.btnCloseTable.FlatAppearance.BorderSize = 2;
//            this.btnCloseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnCloseTable.ForeColor = System.Drawing.SystemColors.ControlText;
//            this.btnCloseTable.Location = new System.Drawing.Point(184, 32);
//            this.btnCloseTable.Name = "btnCloseTable";
//            this.btnCloseTable.Size = new System.Drawing.Size(146, 67);
//            this.btnCloseTable.TabIndex = 1;
//            this.btnCloseTable.Text = "CloseTable";
//            this.btnCloseTable.UseVisualStyleBackColor = false;
//            this.btnCloseTable.Click += new System.EventHandler(this.btnTableState_Click);
//            // 
//            // btnOpenTable
//            // 
//            this.btnOpenTable.BackColor = System.Drawing.Color.LimeGreen;
//            this.btnOpenTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//            this.btnOpenTable.FlatAppearance.BorderSize = 2;
//            this.btnOpenTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnOpenTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnOpenTable.ForeColor = System.Drawing.SystemColors.ControlText;
//            this.btnOpenTable.Location = new System.Drawing.Point(18, 32);
//            this.btnOpenTable.Name = "btnOpenTable";
//            this.btnOpenTable.Size = new System.Drawing.Size(146, 67);
//            this.btnOpenTable.TabIndex = 0;
//            this.btnOpenTable.Text = "OpenTable";
//            this.btnOpenTable.UseVisualStyleBackColor = false;
//            this.btnOpenTable.Click += new System.EventHandler(this.btnTableState_Click);
//            // 
//            // lblAreaText
//            // 
//            this.lblAreaText.AutoSize = true;
//            this.lblAreaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblAreaText.ForeColor = System.Drawing.Color.Maroon;
//            this.lblAreaText.Location = new System.Drawing.Point(47, 205);
//            this.lblAreaText.Name = "lblAreaText";
//            this.lblAreaText.Size = new System.Drawing.Size(58, 25);
//            this.lblAreaText.TabIndex = 14;
//            this.lblAreaText.Text = "Area";
//            // 
//            // lblCompanyId
//            // 
//            this.lblCompanyId.AutoSize = true;
//            this.lblCompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCompanyId.ForeColor = System.Drawing.Color.Blue;
//            this.lblCompanyId.Location = new System.Drawing.Point(437, 23);
//            this.lblCompanyId.Name = "lblCompanyId";
//            this.lblCompanyId.Size = new System.Drawing.Size(108, 17);
//            this.lblCompanyId.TabIndex = 5;
//            this.lblCompanyId.Text = "CompanyGuid";
//            this.lblCompanyId.Visible = false;
//            // 
//            // lblCompanyIdText
//            // 
//            this.lblCompanyIdText.AutoSize = true;
//            this.lblCompanyIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCompanyIdText.Location = new System.Drawing.Point(344, 22);
//            this.lblCompanyIdText.Name = "lblCompanyIdText";
//            this.lblCompanyIdText.Size = new System.Drawing.Size(87, 17);
//            this.lblCompanyIdText.TabIndex = 4;
//            this.lblCompanyIdText.Text = "CompanyId";
//            this.lblCompanyIdText.Visible = false;
//            // 
//            // lblStoreId
//            // 
//            this.lblStoreId.AutoSize = true;
//            this.lblStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblStoreId.ForeColor = System.Drawing.Color.Blue;
//            this.lblStoreId.Location = new System.Drawing.Point(679, 22);
//            this.lblStoreId.Name = "lblStoreId";
//            this.lblStoreId.Size = new System.Drawing.Size(81, 17);
//            this.lblStoreId.TabIndex = 3;
//            this.lblStoreId.Text = "StoreGuid";
//            this.lblStoreId.Visible = false;
//            // 
//            // lblStoreNameText
//            // 
//            this.lblStoreNameText.AutoSize = true;
//            this.lblStoreNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblStoreNameText.Location = new System.Drawing.Point(602, 22);
//            this.lblStoreNameText.Name = "lblStoreNameText";
//            this.lblStoreNameText.Size = new System.Drawing.Size(60, 17);
//            this.lblStoreNameText.TabIndex = 2;
//            this.lblStoreNameText.Text = "StoreId";
//            this.lblStoreNameText.Visible = false;
//            // 
//            // lblTerminalId
//            // 
//            this.lblTerminalId.AutoSize = true;
//            this.lblTerminalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTerminalId.ForeColor = System.Drawing.Color.Blue;
//            this.lblTerminalId.Location = new System.Drawing.Point(895, 22);
//            this.lblTerminalId.Name = "lblTerminalId";
//            this.lblTerminalId.Size = new System.Drawing.Size(105, 17);
//            this.lblTerminalId.TabIndex = 1;
//            this.lblTerminalId.Text = "TerminalGuid";
//            this.lblTerminalId.Visible = false;
//            // 
//            // lblTerminalIdText
//            // 
//            this.lblTerminalIdText.AutoSize = true;
//            this.lblTerminalIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTerminalIdText.Location = new System.Drawing.Point(805, 22);
//            this.lblTerminalIdText.Name = "lblTerminalIdText";
//            this.lblTerminalIdText.Size = new System.Drawing.Size(84, 17);
//            this.lblTerminalIdText.TabIndex = 0;
//            this.lblTerminalIdText.Text = "TerminalId";
//            this.lblTerminalIdText.Visible = false;
//            // 
//            // timer
//            // 
//            this.timer.Enabled = true;
//            this.timer.Interval = 1000;
//            this.timer.Tick += new System.EventHandler(this.timer_Tick);
//            // 
//            // Table
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.Gainsboro;
//            this.ClientSize = new System.Drawing.Size(1024, 768);
//            this.Controls.Add(this.gbxMainViewcontainer);
//            this.Controls.Add(this.lblTerminalIdText);
//            this.Controls.Add(this.lblCompanyId);
//            this.Controls.Add(this.lblTerminalId);
//            this.Controls.Add(this.lblCompanyIdText);
//            this.Controls.Add(this.lblStoreNameText);
//            this.Controls.Add(this.lblStoreId);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "Table";
//            this.ShowInTaskbar = false;
//            this.Text = "Table";
//            this.gbxMainViewcontainer.ResumeLayout(false);
//            this.gbxMainViewcontainer.PerformLayout();
//            this.gbTableActionButtons.ResumeLayout(false);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox gbxMainViewcontainer;
//        private System.Windows.Forms.FlowLayoutPanel flPnlTables;
//        private System.Windows.Forms.Button btnReturn;
//        private System.Windows.Forms.ComboBox cbxArea;
//        private System.Windows.Forms.Label lblCompanyId;
//        private System.Windows.Forms.Label lblCompanyIdText;
//        private System.Windows.Forms.Label lblStoreId;
//        private System.Windows.Forms.Label lblStoreNameText;
//        private System.Windows.Forms.Label lblTerminalId;
//        private System.Windows.Forms.Label lblTerminalIdText;
//        private System.Windows.Forms.GroupBox gbTableActionButtons;
//        private System.Windows.Forms.Button btnTakeAway;
//        private System.Windows.Forms.Button btnMoveTable;
//        private System.Windows.Forms.Button btnCloseTable;
//        private System.Windows.Forms.Button btnOpenTable;
//        private System.Windows.Forms.Label lblAreaText;
//        private System.Windows.Forms.Label lblEmployeeName;
//        private System.Windows.Forms.Label lblEmployeeIdText;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label lblTime;
//        private System.Windows.Forms.Label lblDate;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Button btnLogOut;
//        private System.Windows.Forms.Timer timer;

//    }
//}

namespace POSView
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxMainViewcontainer = new System.Windows.Forms.GroupBox();
            this.flPnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.gbTableActionButtons = new System.Windows.Forms.GroupBox();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnMoveTable = new System.Windows.Forms.Button();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnOpenTable = new System.Windows.Forms.Button();
            this.lblAreaText = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeIdText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.gbxMainViewcontainer.SuspendLayout();
            this.gbTableActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainViewcontainer
            // 
            this.gbxMainViewcontainer.Controls.Add(this.label6);
            this.gbxMainViewcontainer.Controls.Add(this.lblTime);
            this.gbxMainViewcontainer.Controls.Add(this.lblDate);
            this.gbxMainViewcontainer.Controls.Add(this.label4);
            this.gbxMainViewcontainer.Controls.Add(this.lblEmployeeName);
            this.gbxMainViewcontainer.Controls.Add(this.lblEmployeeIdText);
            this.gbxMainViewcontainer.Controls.Add(this.btnReturn);
            this.gbxMainViewcontainer.Controls.Add(this.flPnlTables);
            this.gbxMainViewcontainer.Controls.Add(this.cbxArea);
            this.gbxMainViewcontainer.Controls.Add(this.gbTableActionButtons);
            this.gbxMainViewcontainer.Controls.Add(this.lblAreaText);
            this.gbxMainViewcontainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMainViewcontainer.Location = new System.Drawing.Point(12, 27);
            this.gbxMainViewcontainer.Name = "gbxMainViewcontainer";
            this.gbxMainViewcontainer.Size = new System.Drawing.Size(1100, 729);
            this.gbxMainViewcontainer.TabIndex = 0;
            this.gbxMainViewcontainer.TabStop = false;
            this.gbxMainViewcontainer.Text = "Select a Table";
            // 
            // flPnlTables
            // 
            this.flPnlTables.AutoScroll = true;
            this.flPnlTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flPnlTables.Location = new System.Drawing.Point(38, 217);
            this.flPnlTables.Name = "flPnlTables";
            this.flPnlTables.Size = new System.Drawing.Size(1015, 418);
            this.flPnlTables.TabIndex = 20;
            // 
            // cbxArea
            // 
            this.cbxArea.BackColor = System.Drawing.SystemColors.Info;
            this.cbxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(138, 175);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(229, 24);
            this.cbxArea.TabIndex = 18;
            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
            // 
            // gbTableActionButtons
            // 
            this.gbTableActionButtons.Controls.Add(this.btnTakeAway);
            this.gbTableActionButtons.Controls.Add(this.btnMoveTable);
            this.gbTableActionButtons.Controls.Add(this.btnCloseTable);
            this.gbTableActionButtons.Controls.Add(this.btnOpenTable);
            this.gbTableActionButtons.Location = new System.Drawing.Point(36, 69);
            this.gbTableActionButtons.Name = "gbTableActionButtons";
            this.gbTableActionButtons.Size = new System.Drawing.Size(1016, 88);
            this.gbTableActionButtons.TabIndex = 15;
            this.gbTableActionButtons.TabStop = false;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.Navy;
            this.btnTakeAway.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnTakeAway.FlatAppearance.BorderSize = 2;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeAway.Location = new System.Drawing.Point(854, 18);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(136, 63);
            this.btnTakeAway.TabIndex = 3;
            this.btnTakeAway.Text = "TakeAway";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnMoveTable
            // 
            this.btnMoveTable.BackColor = System.Drawing.Color.Tomato;
            this.btnMoveTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoveTable.FlatAppearance.BorderSize = 2;
            this.btnMoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoveTable.Location = new System.Drawing.Point(352, 15);
            this.btnMoveTable.Name = "btnMoveTable";
            this.btnMoveTable.Size = new System.Drawing.Size(146, 67);
            this.btnMoveTable.TabIndex = 2;
            this.btnMoveTable.Text = "MoveTable";
            this.btnMoveTable.UseVisualStyleBackColor = false;
            this.btnMoveTable.Click += new System.EventHandler(this.btnTableState_Click);
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.Silver;
            this.btnCloseTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCloseTable.FlatAppearance.BorderSize = 2;
            this.btnCloseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseTable.Location = new System.Drawing.Point(185, 15);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(146, 67);
            this.btnCloseTable.TabIndex = 1;
            this.btnCloseTable.Text = "CloseTable";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            this.btnCloseTable.Click += new System.EventHandler(this.btnTableState_Click);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOpenTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpenTable.FlatAppearance.BorderSize = 2;
            this.btnOpenTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenTable.Location = new System.Drawing.Point(21, 15);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(146, 67);
            this.btnOpenTable.TabIndex = 0;
            this.btnOpenTable.Text = "OpenTable";
            this.btnOpenTable.UseVisualStyleBackColor = false;
            this.btnOpenTable.Click += new System.EventHandler(this.btnTableState_Click);
            // 
            // lblAreaText
            // 
            this.lblAreaText.AutoSize = true;
            this.lblAreaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAreaText.Location = new System.Drawing.Point(38, 174);
            this.lblAreaText.Name = "lblAreaText";
            this.lblAreaText.Size = new System.Drawing.Size(58, 25);
            this.lblAreaText.TabIndex = 14;
            this.lblAreaText.Text = "Area";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.IndianRed;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(859, 666);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 42);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(95, 39);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(129, 19);
            this.lblEmployeeName.TabIndex = 26;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblEmployeeIdText
            // 
            this.lblEmployeeIdText.AutoSize = true;
            this.lblEmployeeIdText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIdText.Location = new System.Drawing.Point(37, 39);
            this.lblEmployeeIdText.Name = "lblEmployeeIdText";
            this.lblEmployeeIdText.Size = new System.Drawing.Size(51, 19);
            this.lblEmployeeIdText.TabIndex = 25;
            this.lblEmployeeIdText.Text = "User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(501, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(559, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 19);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(376, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 19);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "00/00/00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(316, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date:";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1124, 768);
            this.Controls.Add(this.gbxMainViewcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table";
            this.ShowInTaskbar = false;
            this.Text = "Table";
            this.gbxMainViewcontainer.ResumeLayout(false);
            this.gbxMainViewcontainer.PerformLayout();
            this.gbTableActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainViewcontainer;
        private System.Windows.Forms.FlowLayoutPanel flPnlTables;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.GroupBox gbTableActionButtons;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnMoveTable;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnOpenTable;
        private System.Windows.Forms.Label lblAreaText;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeIdText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer clock;

    }
}




