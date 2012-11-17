namespace POSManager
{
    partial class PaymentView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaleLineItemGridView = new System.Windows.Forms.DataGridView();
            this.lblDiscountDisplay = new System.Windows.Forms.Label();
            this.lblPaidAmountDisplay = new System.Windows.Forms.Label();
            this.lblChangeDisplay = new System.Windows.Forms.Label();
            this.lblTotalAmountDisplay = new System.Windows.Forms.Label();
            this.lblChangaeTag = new System.Windows.Forms.Label();
            this.lblPaidAmountTag = new System.Windows.Forms.Label();
            this.lblDiscountTag = new System.Windows.Forms.Label();
            this.lblTotalAmountTag = new System.Windows.Forms.Label();
            this.btnEftpos = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.PaymentGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPaymentAmountDisplay = new System.Windows.Forms.TextBox();
            this.pnlPaymentKeypadContainer = new System.Windows.Forms.Panel();
            this.btnKeypadRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKeypadEnter = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBackToSale = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SaleLineItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlPaymentKeypadContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaleLineItemGridView
            // 
            this.SaleLineItemGridView.AllowUserToDeleteRows = false;
            this.SaleLineItemGridView.AllowUserToResizeColumns = false;
            this.SaleLineItemGridView.AllowUserToResizeRows = false;
            this.SaleLineItemGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaleLineItemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleLineItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SaleLineItemGridView.ColumnHeadersHeight = 30;
            this.SaleLineItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SaleLineItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Qty,
            this.UnitPrice,
            this.TotalAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleLineItemGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.SaleLineItemGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SaleLineItemGridView.EnableHeadersVisualStyles = false;
            this.SaleLineItemGridView.Location = new System.Drawing.Point(65, 79);
            this.SaleLineItemGridView.MultiSelect = false;
            this.SaleLineItemGridView.Name = "SaleLineItemGridView";
            this.SaleLineItemGridView.ReadOnly = true;
            this.SaleLineItemGridView.RowHeadersVisible = false;
            this.SaleLineItemGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SaleLineItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleLineItemGridView.Size = new System.Drawing.Size(313, 521);
            this.SaleLineItemGridView.TabIndex = 0;
            // 
            // lblDiscountDisplay
            // 
            this.lblDiscountDisplay.AutoSize = true;
            this.lblDiscountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountDisplay.Location = new System.Drawing.Point(163, 93);
            this.lblDiscountDisplay.Name = "lblDiscountDisplay";
            this.lblDiscountDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiscountDisplay.Size = new System.Drawing.Size(54, 20);
            this.lblDiscountDisplay.TabIndex = 7;
            this.lblDiscountDisplay.Text = "$0.00";
            // 
            // lblPaidAmountDisplay
            // 
            this.lblPaidAmountDisplay.AutoSize = true;
            this.lblPaidAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmountDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblPaidAmountDisplay.Location = new System.Drawing.Point(163, 132);
            this.lblPaidAmountDisplay.Name = "lblPaidAmountDisplay";
            this.lblPaidAmountDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaidAmountDisplay.Size = new System.Drawing.Size(54, 20);
            this.lblPaidAmountDisplay.TabIndex = 6;
            this.lblPaidAmountDisplay.Text = "$0.00";
            // 
            // lblChangeDisplay
            // 
            this.lblChangeDisplay.AutoSize = true;
            this.lblChangeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblChangeDisplay.Location = new System.Drawing.Point(163, 169);
            this.lblChangeDisplay.Name = "lblChangeDisplay";
            this.lblChangeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChangeDisplay.Size = new System.Drawing.Size(54, 20);
            this.lblChangeDisplay.TabIndex = 5;
            this.lblChangeDisplay.Text = "$0.00";
            // 
            // lblTotalAmountDisplay
            // 
            this.lblTotalAmountDisplay.AutoSize = true;
            this.lblTotalAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountDisplay.Location = new System.Drawing.Point(163, 59);
            this.lblTotalAmountDisplay.Name = "lblTotalAmountDisplay";
            this.lblTotalAmountDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAmountDisplay.Size = new System.Drawing.Size(54, 20);
            this.lblTotalAmountDisplay.TabIndex = 4;
            this.lblTotalAmountDisplay.Text = "$0.00";
            // 
            // lblChangaeTag
            // 
            this.lblChangaeTag.AutoSize = true;
            this.lblChangaeTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangaeTag.ForeColor = System.Drawing.Color.Black;
            this.lblChangaeTag.Location = new System.Drawing.Point(84, 169);
            this.lblChangaeTag.Name = "lblChangaeTag";
            this.lblChangaeTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChangaeTag.Size = new System.Drawing.Size(81, 20);
            this.lblChangaeTag.TabIndex = 3;
            this.lblChangaeTag.Text = "Change :";
            // 
            // lblPaidAmountTag
            // 
            this.lblPaidAmountTag.AutoSize = true;
            this.lblPaidAmountTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmountTag.ForeColor = System.Drawing.Color.Black;
            this.lblPaidAmountTag.Location = new System.Drawing.Point(45, 132);
            this.lblPaidAmountTag.Name = "lblPaidAmountTag";
            this.lblPaidAmountTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaidAmountTag.Size = new System.Drawing.Size(121, 20);
            this.lblPaidAmountTag.TabIndex = 2;
            this.lblPaidAmountTag.Text = "Paid Amount :";
            // 
            // lblDiscountTag
            // 
            this.lblDiscountTag.AutoSize = true;
            this.lblDiscountTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTag.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountTag.Location = new System.Drawing.Point(76, 93);
            this.lblDiscountTag.Name = "lblDiscountTag";
            this.lblDiscountTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiscountTag.Size = new System.Drawing.Size(90, 20);
            this.lblDiscountTag.TabIndex = 1;
            this.lblDiscountTag.Text = "Discount :";
            // 
            // lblTotalAmountTag
            // 
            this.lblTotalAmountTag.AutoSize = true;
            this.lblTotalAmountTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalAmountTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTag.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountTag.Location = new System.Drawing.Point(40, 59);
            this.lblTotalAmountTag.Name = "lblTotalAmountTag";
            this.lblTotalAmountTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalAmountTag.Size = new System.Drawing.Size(126, 20);
            this.lblTotalAmountTag.TabIndex = 0;
            this.lblTotalAmountTag.Text = "Total Amount :";
            // 
            // btnEftpos
            // 
            this.btnEftpos.BackColor = System.Drawing.Color.DimGray;
            this.btnEftpos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEftpos.FlatAppearance.BorderSize = 2;
            this.btnEftpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEftpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEftpos.ForeColor = System.Drawing.Color.White;
            this.btnEftpos.Location = new System.Drawing.Point(44, 104);
            this.btnEftpos.Name = "btnEftpos";
            this.btnEftpos.Size = new System.Drawing.Size(179, 44);
            this.btnEftpos.TabIndex = 14;
            this.btnEftpos.Text = "Eftpos";
            this.btnEftpos.UseVisualStyleBackColor = false;
            this.btnEftpos.Click += new System.EventHandler(this.btnEftpos_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.DimGray;
            this.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCash.FlatAppearance.BorderSize = 2;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(44, 43);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(179, 44);
            this.btnCash.TabIndex = 13;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // PaymentGridView
            // 
            this.PaymentGridView.AllowUserToResizeColumns = false;
            this.PaymentGridView.AllowUserToResizeRows = false;
            this.PaymentGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaymentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PaymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.PaymentType});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.PaymentGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PaymentGridView.EnableHeadersVisualStyles = false;
            this.PaymentGridView.Location = new System.Drawing.Point(728, 79);
            this.PaymentGridView.MultiSelect = false;
            this.PaymentGridView.Name = "PaymentGridView";
            this.PaymentGridView.ReadOnly = true;
            this.PaymentGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PaymentGridView.RowHeadersVisible = false;
            this.PaymentGridView.RowHeadersWidth = 45;
            this.PaymentGridView.RowTemplate.ReadOnly = true;
            this.PaymentGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PaymentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentGridView.Size = new System.Drawing.Size(232, 229);
            this.PaymentGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCash);
            this.groupBox1.Controls.Add(this.btnEftpos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(424, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 172);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiscountDisplay);
            this.groupBox2.Controls.Add(this.lblTotalAmountTag);
            this.groupBox2.Controls.Add(this.lblPaidAmountDisplay);
            this.groupBox2.Controls.Add(this.lblDiscountTag);
            this.groupBox2.Controls.Add(this.lblChangeDisplay);
            this.groupBox2.Controls.Add(this.lblPaidAmountTag);
            this.groupBox2.Controls.Add(this.lblTotalAmountDisplay);
            this.groupBox2.Controls.Add(this.lblChangaeTag);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(424, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 249);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Details";
            // 
            // tbxPaymentAmountDisplay
            // 
            this.tbxPaymentAmountDisplay.BackColor = System.Drawing.Color.Beige;
            this.tbxPaymentAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaymentAmountDisplay.Location = new System.Drawing.Point(728, 324);
            this.tbxPaymentAmountDisplay.Multiline = true;
            this.tbxPaymentAmountDisplay.Name = "tbxPaymentAmountDisplay";
            this.tbxPaymentAmountDisplay.Size = new System.Drawing.Size(232, 35);
            this.tbxPaymentAmountDisplay.TabIndex = 5;
            this.tbxPaymentAmountDisplay.Text = "$0.00";
            this.tbxPaymentAmountDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlPaymentKeypadContainer
            // 
            this.pnlPaymentKeypadContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentKeypadContainer.Controls.Add(this.btnKeypadRemove);
            this.pnlPaymentKeypadContainer.Controls.Add(this.button1);
            this.pnlPaymentKeypadContainer.Controls.Add(this.btnKeypadEnter);
            this.pnlPaymentKeypadContainer.Controls.Add(this.bntClear);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b0);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b9);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b8);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b7);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b6);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b5);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b4);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b3);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b2);
            this.pnlPaymentKeypadContainer.Controls.Add(this.b1);
            this.pnlPaymentKeypadContainer.Location = new System.Drawing.Point(730, 366);
            this.pnlPaymentKeypadContainer.Name = "pnlPaymentKeypadContainer";
            this.pnlPaymentKeypadContainer.Size = new System.Drawing.Size(230, 234);
            this.pnlPaymentKeypadContainer.TabIndex = 3;
            // 
            // btnKeypadRemove
            // 
            this.btnKeypadRemove.BackColor = System.Drawing.Color.Salmon;
            this.btnKeypadRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeypadRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypadRemove.Location = new System.Drawing.Point(1, 186);
            this.btnKeypadRemove.Name = "btnKeypadRemove";
            this.btnKeypadRemove.Size = new System.Drawing.Size(110, 45);
            this.btnKeypadRemove.TabIndex = 42;
            this.btnKeypadRemove.Text = "Remove";
            this.btnKeypadRemove.UseVisualStyleBackColor = false;
            this.btnKeypadRemove.Click += new System.EventHandler(this.btnKeypadRemove_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 45);
            this.button1.TabIndex = 42;
            this.button1.Tag = ".";
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKeypadDot_Click);
            // 
            // btnKeypadEnter
            // 
            this.btnKeypadEnter.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKeypadEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeypadEnter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypadEnter.Location = new System.Drawing.Point(117, 186);
            this.btnKeypadEnter.Name = "btnKeypadEnter";
            this.btnKeypadEnter.Size = new System.Drawing.Size(110, 45);
            this.btnKeypadEnter.TabIndex = 41;
            this.btnKeypadEnter.Text = "Enter";
            this.btnKeypadEnter.UseVisualStyleBackColor = false;
            this.btnKeypadEnter.Click += new System.EventHandler(this.btnKeypadEnter_Click);
            // 
            // bntClear
            // 
            this.bntClear.BackColor = System.Drawing.Color.Turquoise;
            this.bntClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClear.Location = new System.Drawing.Point(155, 139);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(72, 45);
            this.bntClear.TabIndex = 40;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.btnKeypadClear_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(1, 139);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(72, 45);
            this.b0.TabIndex = 39;
            this.b0.Tag = "0";
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(155, 93);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(72, 45);
            this.b9.TabIndex = 38;
            this.b9.Tag = "9";
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(79, 93);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(72, 45);
            this.b8.TabIndex = 37;
            this.b8.Tag = "8";
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(1, 93);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(72, 45);
            this.b7.TabIndex = 36;
            this.b7.Tag = "7";
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(155, 47);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(72, 45);
            this.b6.TabIndex = 35;
            this.b6.Tag = "6";
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(79, 47);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(72, 45);
            this.b5.TabIndex = 34;
            this.b5.Tag = "5";
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(1, 47);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(72, 45);
            this.b4.TabIndex = 33;
            this.b4.Tag = "4";
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(155, 1);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(72, 45);
            this.b3.TabIndex = 32;
            this.b3.Tag = "3";
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(79, 1);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(72, 45);
            this.b2.TabIndex = 31;
            this.b2.Tag = "2";
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // b1
            // 
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(1, 1);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(72, 45);
            this.b1.TabIndex = 30;
            this.b1.Tag = "1";
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumericKeyClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(844, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBackToSale
            // 
            this.btnBackToSale.BackColor = System.Drawing.Color.LightGray;
            this.btnBackToSale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSale.Location = new System.Drawing.Point(698, 642);
            this.btnBackToSale.Name = "btnBackToSale";
            this.btnBackToSale.Size = new System.Drawing.Size(140, 42);
            this.btnBackToSale.TabIndex = 24;
            this.btnBackToSale.Text = "<< Back to Sale";
            this.btnBackToSale.UseVisualStyleBackColor = false;
            this.btnBackToSale.Click += new System.EventHandler(this.btnBackToSale_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserName.Location = new System.Drawing.Point(170, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 19);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(526, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(584, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 19);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(404, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 19);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "00/00/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(344, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date:";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "ItemDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "SLIQuantity";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 55;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "EachPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitPrice.HeaderText = "Each";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 65;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalAmount.HeaderText = "Total";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 65;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle7;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentType.DefaultCellStyle = dataGridViewCellStyle8;
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            this.PaymentType.Width = 150;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBackToSale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxPaymentAmountDisplay);
            this.Controls.Add(this.pnlPaymentKeypadContainer);
            this.Controls.Add(this.PaymentGridView);
            this.Controls.Add(this.SaleLineItemGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentView";
            this.Load += new System.EventHandler(this.PaymentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleLineItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPaymentKeypadContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SaleLineItemGridView;
        private System.Windows.Forms.Label lblChangaeTag;
        private System.Windows.Forms.Label lblPaidAmountTag;
        private System.Windows.Forms.Label lblDiscountTag;
        private System.Windows.Forms.Label lblTotalAmountTag;
        private System.Windows.Forms.Button btnEftpos;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label lblDiscountDisplay;
        private System.Windows.Forms.Label lblPaidAmountDisplay;
        private System.Windows.Forms.Label lblChangeDisplay;
        private System.Windows.Forms.Label lblTotalAmountDisplay;
        private System.Windows.Forms.DataGridView PaymentGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxPaymentAmountDisplay;
        private System.Windows.Forms.Panel pnlPaymentKeypadContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKeypadEnter;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBackToSale;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeypadRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
    }
}