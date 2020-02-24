namespace WindowsFormsApplication2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ItemGroupBox = new System.Windows.Forms.Panel();
            this.TransactionDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBrandName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentStock1 = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApplication2.AppData();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData1 = new WindowsFormsApplication2.AppData1();
            this.drugsTableAdapter = new WindowsFormsApplication2.AppDataTableAdapters.DrugsTableAdapter();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salesTableAdapter = new WindowsFormsApplication2.AppData1TableAdapters.SalesTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drugIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.CancelOrderbtn = new System.Windows.Forms.Button();
            this.PrintPreviewbtn = new System.Windows.Forms.Button();
            this.PrintOrderbtn = new System.Windows.Forms.Button();
            this.NewOrderbtn = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.time1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 167);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1276, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.date2.Location = new System.Drawing.Point(1059, 3);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(37, 19);
            this.date2.TabIndex = 7;
            this.date2.Text = "sda";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.time1.Location = new System.Drawing.Point(958, 3);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(37, 19);
            this.time1.TabIndex = 7;
            this.time1.Text = "sda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(170, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = " Pharmaceutical System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(73, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "THADZ PHARMACY";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Controls.Add(this.TransactionDateDateTimePicker1);
            this.ItemGroupBox.Controls.Add(this.txtBrandName);
            this.ItemGroupBox.Controls.Add(this.btnAddToCart);
            this.ItemGroupBox.Controls.Add(this.label6);
            this.ItemGroupBox.Controls.Add(this.txtCurrentStock1);
            this.ItemGroupBox.Controls.Add(this.txtCurrentStock);
            this.ItemGroupBox.Controls.Add(this.label5);
            this.ItemGroupBox.Controls.Add(this.txtUnitPrice);
            this.ItemGroupBox.Controls.Add(this.txtOrderNumber);
            this.ItemGroupBox.Controls.Add(this.txtQuantity);
            this.ItemGroupBox.Controls.Add(this.label11);
            this.ItemGroupBox.Controls.Add(this.label10);
            this.ItemGroupBox.Controls.Add(this.label3);
            this.ItemGroupBox.Controls.Add(this.label4);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(12, 173);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(842, 187);
            this.ItemGroupBox.TabIndex = 2;
            // 
            // TransactionDateDateTimePicker1
            // 
            this.TransactionDateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransactionDateDateTimePicker1.Location = new System.Drawing.Point(493, 12);
            this.TransactionDateDateTimePicker1.Name = "TransactionDateDateTimePicker1";
            this.TransactionDateDateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.TransactionDateDateTimePicker1.TabIndex = 15;
            // 
            // txtBrandName
            // 
            this.txtBrandName.FormattingEnabled = true;
            this.txtBrandName.Location = new System.Drawing.Point(14, 95);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(173, 21);
            this.txtBrandName.TabIndex = 14;
            this.txtBrandName.SelectedValueChanged += new System.EventHandler(this.txtBrandName_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "₱";
            // 
            // txtCurrentStock1
            // 
            this.txtCurrentStock1.AutoSize = true;
            this.txtCurrentStock1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStock1.Location = new System.Drawing.Point(193, 127);
            this.txtCurrentStock1.Name = "txtCurrentStock1";
            this.txtCurrentStock1.Size = new System.Drawing.Size(141, 19);
            this.txtCurrentStock1.TabIndex = 11;
            this.txtCurrentStock1.Text = "Amount/Dosage:";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(197, 149);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(155, 20);
            this.txtCurrentStock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(36, 148);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(133, 20);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(141, 15);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(137, 20);
            this.txtOrderNumber.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(211, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(155, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Brand Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(346, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Transaction Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "Drugs";
            this.drugsBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.appData1;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData1";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // CartGridView
            // 
            this.CartGridView.AllowUserToAddRows = false;
            this.CartGridView.AllowUserToOrderColumns = true;
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(12, 375);
            this.CartGridView.MultiSelect = false;
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGridView.Size = new System.Drawing.Size(752, 210);
            this.CartGridView.TabIndex = 13;
            this.CartGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartGridView_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1083, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(1219, 657);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(133, 27);
            this.txtTotalAmount.TabIndex = 10;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalPay.Location = new System.Drawing.Point(1219, 732);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(133, 27);
            this.txtTotalPay.TabIndex = 10;
            this.txtTotalPay.Text = "0";
            this.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1098, 735);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total to Pay:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtSalesTax.Location = new System.Drawing.Point(1219, 694);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(133, 27);
            this.txtSalesTax.TabIndex = 10;
            this.txtSalesTax.Text = "0";
            this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesTax.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1067, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sales Tax (16%):";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeQuantityToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
            // 
            // changeQuantityToolStripMenuItem
            // 
            this.changeQuantityToolStripMenuItem.Name = "changeQuantityToolStripMenuItem";
            this.changeQuantityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.changeQuantityToolStripMenuItem.Text = "Change Quantity";
            this.changeQuantityToolStripMenuItem.Click += new System.EventHandler(this.changeQuantityToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1043, 627);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Discount (SC/PWD):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(770, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 210);
            this.dataGridView1.TabIndex = 16;
            // 
            // drugIDDataGridViewTextBoxColumn
            // 
            this.drugIDDataGridViewTextBoxColumn.DataPropertyName = "DrugID";
            this.drugIDDataGridViewTextBoxColumn.HeaderText = "DrugID";
            this.drugIDDataGridViewTextBoxColumn.Name = "drugIDDataGridViewTextBoxColumn";
            this.drugIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnCash
            // 
            this.btnCash.Enabled = false;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCash.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Cash_in_Hand_32;
            this.btnCash.Location = new System.Drawing.Point(750, 641);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(201, 99);
            this.btnCash.TabIndex = 15;
            this.btnCash.Text = "   Process Order";
            this.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDiscount.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Credit_Card_32;
            this.btnDiscount.Location = new System.Drawing.Point(505, 644);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(201, 99);
            this.btnDiscount.TabIndex = 15;
            this.btnDiscount.Text = "   Discount";
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // CancelOrderbtn
            // 
            this.CancelOrderbtn.Enabled = false;
            this.CancelOrderbtn.FlatAppearance.BorderSize = 0;
            this.CancelOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOrderbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CancelOrderbtn.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Cancel_32;
            this.CancelOrderbtn.Location = new System.Drawing.Point(12, 641);
            this.CancelOrderbtn.Name = "CancelOrderbtn";
            this.CancelOrderbtn.Size = new System.Drawing.Size(245, 62);
            this.CancelOrderbtn.TabIndex = 14;
            this.CancelOrderbtn.Text = "   Cancel Order";
            this.CancelOrderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelOrderbtn.UseVisualStyleBackColor = true;
            this.CancelOrderbtn.Click += new System.EventHandler(this.CancelOrderbtn_Click);
            // 
            // PrintPreviewbtn
            // 
            this.PrintPreviewbtn.Enabled = false;
            this.PrintPreviewbtn.FlatAppearance.BorderSize = 0;
            this.PrintPreviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrintPreviewbtn.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Overview_32;
            this.PrintPreviewbtn.Location = new System.Drawing.Point(1111, 263);
            this.PrintPreviewbtn.Name = "PrintPreviewbtn";
            this.PrintPreviewbtn.Size = new System.Drawing.Size(245, 62);
            this.PrintPreviewbtn.TabIndex = 12;
            this.PrintPreviewbtn.Text = "    Print Preview";
            this.PrintPreviewbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintPreviewbtn.UseVisualStyleBackColor = true;
            this.PrintPreviewbtn.Click += new System.EventHandler(this.PrintPreviewbtn_Click);
            // 
            // PrintOrderbtn
            // 
            this.PrintOrderbtn.Enabled = false;
            this.PrintOrderbtn.FlatAppearance.BorderSize = 0;
            this.PrintOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintOrderbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PrintOrderbtn.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Print_32;
            this.PrintOrderbtn.Location = new System.Drawing.Point(1111, 173);
            this.PrintOrderbtn.Name = "PrintOrderbtn";
            this.PrintOrderbtn.Size = new System.Drawing.Size(245, 62);
            this.PrintOrderbtn.TabIndex = 12;
            this.PrintOrderbtn.Text = "   Print Order";
            this.PrintOrderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintOrderbtn.UseVisualStyleBackColor = true;
            this.PrintOrderbtn.Click += new System.EventHandler(this.PrintOrderbtn_Click);
            // 
            // NewOrderbtn
            // 
            this.NewOrderbtn.FlatAppearance.BorderSize = 0;
            this.NewOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NewOrderbtn.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Purchase_Order_32;
            this.NewOrderbtn.Location = new System.Drawing.Point(860, 173);
            this.NewOrderbtn.Name = "NewOrderbtn";
            this.NewOrderbtn.Size = new System.Drawing.Size(245, 62);
            this.NewOrderbtn.TabIndex = 12;
            this.NewOrderbtn.Text = "   New Order";
            this.NewOrderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewOrderbtn.UseVisualStyleBackColor = true;
            this.NewOrderbtn.Click += new System.EventHandler(this.NewOrderbtn_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_Shopping_Cart_32;
            this.btnAddToCart.Location = new System.Drawing.Point(637, 52);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(181, 111);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_News_32;
            this.button5.Location = new System.Drawing.Point(228, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 63);
            this.button5.TabIndex = 12;
            this.button5.Text = "Reports";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_About_32;
            this.button4.Location = new System.Drawing.Point(153, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 63);
            this.button4.TabIndex = 12;
            this.button4.Text = "About";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.sales1_32;
            this.button3.Location = new System.Drawing.Point(78, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sales";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.gamot_32;
            this.button2.Location = new System.Drawing.Point(3, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Drugs";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication2.Properties.Resources.red_bowl_of_hygeia;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalDiscount.Location = new System.Drawing.Point(1219, 619);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(133, 27);
            this.txtTotalDiscount.TabIndex = 10;
            this.txtTotalDiscount.Text = "0";
            this.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.CancelOrderbtn);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.txtTotalDiscount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.PrintPreviewbtn);
            this.Controls.Add(this.PrintOrderbtn);
            this.Controls.Add(this.NewOrderbtn);
            this.Controls.Add(this.ItemGroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ItemGroupBox;
        private System.Windows.Forms.Button button4;
        private AppData appData;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private AppDataTableAdapters.DrugsTableAdapter drugsTableAdapter;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button PrintPreviewbtn;
        private System.Windows.Forms.Button PrintOrderbtn;
        private System.Windows.Forms.Button NewOrderbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelOrderbtn;
        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalesTax;
        private AppData1 appData1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private AppData1TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox txtBrandName;
        private System.Windows.Forms.ToolStripMenuItem changeQuantityToolStripMenuItem;
        private System.Windows.Forms.Label txtCurrentStock1;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.DateTimePicker TransactionDateDateTimePicker1;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTotalDiscount;
    }
}