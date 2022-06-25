namespace MobileShopManagement
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblimei1 = new System.Windows.Forms.Label();
            this.lblimei2 = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.lblmmfgdate = new System.Windows.Forms.Label();
            this.lblmwaranty = new System.Windows.Forms.Label();
            this.lblmprice = new System.Windows.Forms.Label();
            this.txtimei1 = new System.Windows.Forms.TextBox();
            this.txtimei2 = new System.Windows.Forms.TextBox();
            this.txtmprice = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtmwaranty = new System.Windows.Forms.TextBox();
            this.btnaddstock = new System.Windows.Forms.Button();
            this.mmfgdate = new System.Windows.Forms.DateTimePicker();
            this.lblmyear = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblpmfgdate = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.pmfgdate = new System.Windows.Forms.DateTimePicker();
            this.lblpprice = new System.Windows.Forms.Label();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblpwaranty = new System.Windows.Forms.Label();
            this.lblpyear = new System.Windows.Forms.Label();
            this.txtpwaranty = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpmodel = new System.Windows.Forms.TextBox();
            this.lblpmodel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnviewstock = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclere = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl21 = new MobileShopManagement.UserControl2();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpsellprice = new System.Windows.Forms.TextBox();
            this.lblpsprice = new System.Windows.Forms.Label();
            this.txtmsellprice = new System.Windows.Forms.TextBox();
            this.lblmsprice = new System.Windows.Forms.Label();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgsttotal = new System.Windows.Forms.Label();
            this.txtgsttotal = new System.Windows.Forms.TextBox();
            this.txtoid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Product Type =";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select",
            "Mobile",
            "Accessaries"});
            this.comboBox1.Location = new System.Drawing.Point(221, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(547, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblimei1
            // 
            this.lblimei1.AutoSize = true;
            this.lblimei1.BackColor = System.Drawing.Color.Transparent;
            this.lblimei1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimei1.ForeColor = System.Drawing.Color.Black;
            this.lblimei1.Location = new System.Drawing.Point(27, 299);
            this.lblimei1.Name = "lblimei1";
            this.lblimei1.Size = new System.Drawing.Size(102, 18);
            this.lblimei1.TabIndex = 5;
            this.lblimei1.Text = "IMEI No 1 = ";
            // 
            // lblimei2
            // 
            this.lblimei2.AutoSize = true;
            this.lblimei2.BackColor = System.Drawing.Color.Transparent;
            this.lblimei2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimei2.ForeColor = System.Drawing.Color.Black;
            this.lblimei2.Location = new System.Drawing.Point(354, 299);
            this.lblimei2.Name = "lblimei2";
            this.lblimei2.Size = new System.Drawing.Size(102, 18);
            this.lblimei2.TabIndex = 6;
            this.lblimei2.Text = "IMEI No 2 = ";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.ForeColor = System.Drawing.Color.Black;
            this.lblmodel.Location = new System.Drawing.Point(27, 353);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(74, 18);
            this.lblmodel.TabIndex = 7;
            this.lblmodel.Text = "Model = ";
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.BackColor = System.Drawing.Color.Transparent;
            this.lblcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.ForeColor = System.Drawing.Color.Black;
            this.lblcname.Location = new System.Drawing.Point(354, 354);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(99, 18);
            this.lblcname.TabIndex = 8;
            this.lblcname.Text = "Company = ";
            // 
            // lblmmfgdate
            // 
            this.lblmmfgdate.AutoSize = true;
            this.lblmmfgdate.BackColor = System.Drawing.Color.Transparent;
            this.lblmmfgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmmfgdate.ForeColor = System.Drawing.Color.Black;
            this.lblmmfgdate.Location = new System.Drawing.Point(709, 299);
            this.lblmmfgdate.Name = "lblmmfgdate";
            this.lblmmfgdate.Size = new System.Drawing.Size(96, 18);
            this.lblmmfgdate.TabIndex = 9;
            this.lblmmfgdate.Text = "Mfg Date = ";
            // 
            // lblmwaranty
            // 
            this.lblmwaranty.AutoSize = true;
            this.lblmwaranty.BackColor = System.Drawing.Color.Transparent;
            this.lblmwaranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmwaranty.ForeColor = System.Drawing.Color.Black;
            this.lblmwaranty.Location = new System.Drawing.Point(709, 355);
            this.lblmwaranty.Name = "lblmwaranty";
            this.lblmwaranty.Size = new System.Drawing.Size(90, 18);
            this.lblmwaranty.TabIndex = 10;
            this.lblmwaranty.Text = "Waranty = ";
            // 
            // lblmprice
            // 
            this.lblmprice.AutoSize = true;
            this.lblmprice.BackColor = System.Drawing.Color.Transparent;
            this.lblmprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmprice.ForeColor = System.Drawing.Color.Black;
            this.lblmprice.Location = new System.Drawing.Point(1061, 300);
            this.lblmprice.Name = "lblmprice";
            this.lblmprice.Size = new System.Drawing.Size(67, 18);
            this.lblmprice.TabIndex = 11;
            this.lblmprice.Text = "Price = ";
            // 
            // txtimei1
            // 
            this.txtimei1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimei1.Location = new System.Drawing.Point(161, 299);
            this.txtimei1.MaxLength = 15;
            this.txtimei1.Multiline = true;
            this.txtimei1.Name = "txtimei1";
            this.txtimei1.Size = new System.Drawing.Size(160, 20);
            this.txtimei1.TabIndex = 12;
            this.txtimei1.TextChanged += new System.EventHandler(this.txtimei1_TextChanged);
            this.txtimei1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimei1_KeyDown);
            this.txtimei1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimei1_KeyPress);
            // 
            // txtimei2
            // 
            this.txtimei2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimei2.Location = new System.Drawing.Point(488, 299);
            this.txtimei2.MaxLength = 15;
            this.txtimei2.Multiline = true;
            this.txtimei2.Name = "txtimei2";
            this.txtimei2.Size = new System.Drawing.Size(186, 20);
            this.txtimei2.TabIndex = 13;
            this.txtimei2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimei2_KeyDown);
            this.txtimei2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimei2_KeyPress);
            // 
            // txtmprice
            // 
            this.txtmprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmprice.Location = new System.Drawing.Point(1151, 299);
            this.txtmprice.Multiline = true;
            this.txtmprice.Name = "txtmprice";
            this.txtmprice.ReadOnly = true;
            this.txtmprice.Size = new System.Drawing.Size(207, 20);
            this.txtmprice.TabIndex = 15;
            this.txtmprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmprice_KeyDown);
            this.txtmprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(161, 352);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.ReadOnly = true;
            this.txtmodel.Size = new System.Drawing.Size(160, 20);
            this.txtmodel.TabIndex = 16;
            this.txtmodel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmodel_KeyDown);
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(488, 352);
            this.txtcname.Multiline = true;
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(186, 20);
            this.txtcname.TabIndex = 17;
            this.txtcname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcname_KeyDown);
            // 
            // txtmwaranty
            // 
            this.txtmwaranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmwaranty.Location = new System.Drawing.Point(830, 352);
            this.txtmwaranty.Multiline = true;
            this.txtmwaranty.Name = "txtmwaranty";
            this.txtmwaranty.Size = new System.Drawing.Size(189, 20);
            this.txtmwaranty.TabIndex = 18;
            this.txtmwaranty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmwaranty_KeyDown);
            // 
            // btnaddstock
            // 
            this.btnaddstock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddstock.BackgroundImage")));
            this.btnaddstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddstock.Location = new System.Drawing.Point(153, 451);
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Size = new System.Drawing.Size(118, 26);
            this.btnaddstock.TabIndex = 19;
            this.btnaddstock.Text = "Add Stock";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // mmfgdate
            // 
            this.mmfgdate.CustomFormat = "dd/MM/yyyy";
            this.mmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mmfgdate.Location = new System.Drawing.Point(830, 299);
            this.mmfgdate.MaxDate = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            this.mmfgdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mmfgdate.Name = "mmfgdate";
            this.mmfgdate.Size = new System.Drawing.Size(189, 20);
            this.mmfgdate.TabIndex = 20;
            this.mmfgdate.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            this.mmfgdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mmfgdate_KeyDown);
            // 
            // lblmyear
            // 
            this.lblmyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmyear.Location = new System.Drawing.Point(972, 352);
            this.lblmyear.Name = "lblmyear";
            this.lblmyear.Size = new System.Drawing.Size(47, 20);
            this.lblmyear.TabIndex = 23;
            this.lblmyear.Text = "Year ";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.BackColor = System.Drawing.Color.Transparent;
            this.lblpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.Black;
            this.lblpname.Location = new System.Drawing.Point(18, 298);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(136, 18);
            this.lblpname.TabIndex = 25;
            this.lblpname.Text = "Product Name = ";
            this.lblpname.Click += new System.EventHandler(this.lblpname_Click);
            // 
            // lblpmfgdate
            // 
            this.lblpmfgdate.AutoSize = true;
            this.lblpmfgdate.BackColor = System.Drawing.Color.Transparent;
            this.lblpmfgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmfgdate.ForeColor = System.Drawing.Color.Black;
            this.lblpmfgdate.Location = new System.Drawing.Point(703, 301);
            this.lblpmfgdate.Name = "lblpmfgdate";
            this.lblpmfgdate.Size = new System.Drawing.Size(96, 18);
            this.lblpmfgdate.TabIndex = 26;
            this.lblpmfgdate.Text = "Mfg Date = ";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(161, 299);
            this.txtpname.Multiline = true;
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(176, 20);
            this.txtpname.TabIndex = 28;
            // 
            // pmfgdate
            // 
            this.pmfgdate.CustomFormat = " dd/MM/yyyy";
            this.pmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pmfgdate.Location = new System.Drawing.Point(830, 299);
            this.pmfgdate.MaxDate = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            this.pmfgdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.pmfgdate.Name = "pmfgdate";
            this.pmfgdate.Size = new System.Drawing.Size(189, 20);
            this.pmfgdate.TabIndex = 29;
            this.pmfgdate.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // lblpprice
            // 
            this.lblpprice.AutoSize = true;
            this.lblpprice.BackColor = System.Drawing.Color.Transparent;
            this.lblpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpprice.ForeColor = System.Drawing.Color.Black;
            this.lblpprice.Location = new System.Drawing.Point(1061, 304);
            this.lblpprice.Name = "lblpprice";
            this.lblpprice.Size = new System.Drawing.Size(67, 18);
            this.lblpprice.TabIndex = 30;
            this.lblpprice.Text = "Price = ";
            // 
            // txtpprice
            // 
            this.txtpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpprice.Location = new System.Drawing.Point(1151, 299);
            this.txtpprice.Multiline = true;
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.ReadOnly = true;
            this.txtpprice.Size = new System.Drawing.Size(207, 20);
            this.txtpprice.TabIndex = 31;
            this.txtpprice.TextChanged += new System.EventHandler(this.txtpprice_TextChanged);
            this.txtpprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpprice_KeyPress);
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Black;
            this.lblqty.Location = new System.Drawing.Point(27, 353);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(90, 18);
            this.lblqty.TabIndex = 32;
            this.lblqty.Text = "Quantity = ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(362, 353);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(66, 18);
            this.lbltotal.TabIndex = 33;
            this.lbltotal.Text = "Total = ";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(161, 353);
            this.txtqty.Multiline = true;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(176, 20);
            this.txtqty.TabIndex = 34;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // lblpwaranty
            // 
            this.lblpwaranty.AutoSize = true;
            this.lblpwaranty.BackColor = System.Drawing.Color.Transparent;
            this.lblpwaranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwaranty.ForeColor = System.Drawing.Color.Black;
            this.lblpwaranty.Location = new System.Drawing.Point(709, 354);
            this.lblpwaranty.Name = "lblpwaranty";
            this.lblpwaranty.Size = new System.Drawing.Size(90, 18);
            this.lblpwaranty.TabIndex = 35;
            this.lblpwaranty.Text = "Waranty = ";
            // 
            // lblpyear
            // 
            this.lblpyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpyear.Location = new System.Drawing.Point(972, 352);
            this.lblpyear.Name = "lblpyear";
            this.lblpyear.Size = new System.Drawing.Size(47, 20);
            this.lblpyear.TabIndex = 37;
            this.lblpyear.Text = "Year ";
            // 
            // txtpwaranty
            // 
            this.txtpwaranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwaranty.Location = new System.Drawing.Point(830, 352);
            this.txtpwaranty.Multiline = true;
            this.txtpwaranty.Name = "txtpwaranty";
            this.txtpwaranty.Size = new System.Drawing.Size(189, 20);
            this.txtpwaranty.TabIndex = 36;
            this.txtpwaranty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpwaranty_KeyDown);
            this.txtpwaranty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpwaranty_KeyPress);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(488, 353);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(200, 20);
            this.txttotal.TabIndex = 40;
            this.txttotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttotal_KeyDown);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // txtpmodel
            // 
            this.txtpmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmodel.Location = new System.Drawing.Point(488, 299);
            this.txtpmodel.Multiline = true;
            this.txtpmodel.Name = "txtpmodel";
            this.txtpmodel.Size = new System.Drawing.Size(200, 20);
            this.txtpmodel.TabIndex = 41;
            // 
            // lblpmodel
            // 
            this.lblpmodel.AutoSize = true;
            this.lblpmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblpmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmodel.ForeColor = System.Drawing.Color.Black;
            this.lblpmodel.Location = new System.Drawing.Point(354, 298);
            this.lblpmodel.Name = "lblpmodel";
            this.lblpmodel.Size = new System.Drawing.Size(74, 18);
            this.lblpmodel.TabIndex = 42;
            this.lblpmodel.Text = "Model = ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(54, 504);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1268, 160);
            this.dataGridView2.TabIndex = 43;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnviewstock
            // 
            this.btnviewstock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnviewstock.BackgroundImage")));
            this.btnviewstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnviewstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewstock.Location = new System.Drawing.Point(357, 451);
            this.btnviewstock.Name = "btnviewstock";
            this.btnviewstock.Size = new System.Drawing.Size(118, 26);
            this.btnviewstock.TabIndex = 44;
            this.btnviewstock.Text = "View Stock";
            this.btnviewstock.UseVisualStyleBackColor = true;
            this.btnviewstock.Click += new System.EventHandler(this.btnviewstock_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(579, 451);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 26);
            this.btnupdate.TabIndex = 45;
            this.btnupdate.Text = "Update Stock";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclere
            // 
            this.btnclere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclere.BackgroundImage")));
            this.btnclere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclere.Location = new System.Drawing.Point(833, 451);
            this.btnclere.Name = "btnclere";
            this.btnclere.Size = new System.Drawing.Size(118, 26);
            this.btnclere.TabIndex = 46;
            this.btnclere.Text = "Clere";
            this.btnclere.UseVisualStyleBackColor = true;
            this.btnclere.Click += new System.EventHandler(this.btnclere_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(1056, 451);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(118, 26);
            this.btncancel.TabIndex = 47;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 123);
            this.panel1.TabIndex = 1;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl21.Location = new System.Drawing.Point(157, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1067, 123);
            this.userControl21.TabIndex = 0;
            // 
            // txttotalamount
            // 
            this.txttotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamount.Location = new System.Drawing.Point(161, 404);
            this.txttotalamount.Multiline = true;
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(176, 20);
            this.txttotalamount.TabIndex = 51;
            this.txttotalamount.TextChanged += new System.EventHandler(this.txttotalamount_TextChanged);
            this.txttotalamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttotalamount_KeyDown);
            this.txttotalamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotalamount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "GST Price = ";
            // 
            // txtpsellprice
            // 
            this.txtpsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpsellprice.Location = new System.Drawing.Point(488, 404);
            this.txtpsellprice.Multiline = true;
            this.txtpsellprice.Name = "txtpsellprice";
            this.txtpsellprice.Size = new System.Drawing.Size(200, 20);
            this.txtpsellprice.TabIndex = 55;
            // 
            // lblpsprice
            // 
            this.lblpsprice.AutoSize = true;
            this.lblpsprice.BackColor = System.Drawing.Color.Transparent;
            this.lblpsprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpsprice.ForeColor = System.Drawing.Color.Black;
            this.lblpsprice.Location = new System.Drawing.Point(362, 404);
            this.lblpsprice.Name = "lblpsprice";
            this.lblpsprice.Size = new System.Drawing.Size(100, 18);
            this.lblpsprice.TabIndex = 54;
            this.lblpsprice.Text = "Sell Price = ";
            // 
            // txtmsellprice
            // 
            this.txtmsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsellprice.Location = new System.Drawing.Point(488, 404);
            this.txtmsellprice.Multiline = true;
            this.txtmsellprice.Name = "txtmsellprice";
            this.txtmsellprice.Size = new System.Drawing.Size(200, 20);
            this.txtmsellprice.TabIndex = 53;
            this.txtmsellprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmsellprice_KeyDown);
            // 
            // lblmsprice
            // 
            this.lblmsprice.AutoSize = true;
            this.lblmsprice.BackColor = System.Drawing.Color.Transparent;
            this.lblmsprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsprice.ForeColor = System.Drawing.Color.Black;
            this.lblmsprice.Location = new System.Drawing.Point(362, 407);
            this.lblmsprice.Name = "lblmsprice";
            this.lblmsprice.Size = new System.Drawing.Size(100, 18);
            this.lblmsprice.TabIndex = 52;
            this.lblmsprice.Text = "Sell Price = ";
            // 
            // txtgst
            // 
            this.txtgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgst.Location = new System.Drawing.Point(1151, 353);
            this.txtgst.Multiline = true;
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(207, 20);
            this.txtgst.TabIndex = 57;
            this.txtgst.TextChanged += new System.EventHandler(this.txtgst_TextChanged_1);
            this.txtgst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgst_KeyDown);
            this.txtgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgst_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1066, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "GST = ";
            // 
            // lblgsttotal
            // 
            this.lblgsttotal.AutoSize = true;
            this.lblgsttotal.BackColor = System.Drawing.Color.Transparent;
            this.lblgsttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgsttotal.ForeColor = System.Drawing.Color.Black;
            this.lblgsttotal.Location = new System.Drawing.Point(709, 404);
            this.lblgsttotal.Name = "lblgsttotal";
            this.lblgsttotal.Size = new System.Drawing.Size(105, 18);
            this.lblgsttotal.TabIndex = 58;
            this.lblgsttotal.Text = "GST Total = ";
            // 
            // txtgsttotal
            // 
            this.txtgsttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgsttotal.Location = new System.Drawing.Point(830, 404);
            this.txtgsttotal.Multiline = true;
            this.txtgsttotal.Name = "txtgsttotal";
            this.txtgsttotal.ReadOnly = true;
            this.txtgsttotal.Size = new System.Drawing.Size(189, 20);
            this.txtgsttotal.TabIndex = 59;
            // 
            // txtoid
            // 
            this.txtoid.Location = new System.Drawing.Point(221, 143);
            this.txtoid.Name = "txtoid";
            this.txtoid.Size = new System.Drawing.Size(100, 20);
            this.txtoid.TabIndex = 60;
            this.txtoid.TextChanged += new System.EventHandler(this.txtoid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Enter Order Id =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Supplier Name = ";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.Color.Transparent;
            this.lblsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.ForeColor = System.Drawing.Color.Black;
            this.lblsname.Location = new System.Drawing.Point(218, 239);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(105, 18);
            this.lblsname.TabIndex = 63;
            this.lblsname.Text = "Supplier Name";
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(386, 140);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 26);
            this.btnsearch.TabIndex = 64;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblsname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtoid);
            this.Controls.Add(this.txtgsttotal);
            this.Controls.Add(this.lblgsttotal);
            this.Controls.Add(this.txtgst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpsellprice);
            this.Controls.Add(this.lblpsprice);
            this.Controls.Add(this.txtmsellprice);
            this.Controls.Add(this.lblmsprice);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnclere);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnviewstock);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblpmodel);
            this.Controls.Add(this.txtpmodel);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lblpyear);
            this.Controls.Add(this.txtpwaranty);
            this.Controls.Add(this.lblpwaranty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtpprice);
            this.Controls.Add(this.lblpprice);
            this.Controls.Add(this.pmfgdate);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.lblpmfgdate);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lblmyear);
            this.Controls.Add(this.mmfgdate);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.txtmwaranty);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtmprice);
            this.Controls.Add(this.txtimei2);
            this.Controls.Add(this.txtimei1);
            this.Controls.Add(this.lblmprice);
            this.Controls.Add(this.lblmwaranty);
            this.Controls.Add(this.lblmmfgdate);
            this.Controls.Add(this.lblcname);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblimei2);
            this.Controls.Add(this.lblimei1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblimei1;
        private System.Windows.Forms.Label lblimei2;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblmmfgdate;
        private System.Windows.Forms.Label lblmwaranty;
        private System.Windows.Forms.Label lblmprice;
        private System.Windows.Forms.TextBox txtimei1;
        private System.Windows.Forms.TextBox txtimei2;
        private System.Windows.Forms.TextBox txtmprice;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtmwaranty;
        private System.Windows.Forms.Button btnaddstock;
        private System.Windows.Forms.DateTimePicker mmfgdate;
        private System.Windows.Forms.Label lblmyear;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblpmfgdate;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.DateTimePicker pmfgdate;
        private System.Windows.Forms.Label lblpprice;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblpwaranty;
        private System.Windows.Forms.Label lblpyear;
        private System.Windows.Forms.TextBox txtpwaranty;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpmodel;
        private System.Windows.Forms.Label lblpmodel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnviewstock;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclere;
        private System.Windows.Forms.Button btncancel;
        private UserControl2 userControl21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpsellprice;
        private System.Windows.Forms.Label lblpsprice;
        private System.Windows.Forms.TextBox txtmsellprice;
        private System.Windows.Forms.Label lblmsprice;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgsttotal;
        private System.Windows.Forms.TextBox txtgsttotal;
        private System.Windows.Forms.TextBox txtoid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Button btnsearch;
    }
}