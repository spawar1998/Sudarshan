namespace MobileShopManagement
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl21 = new MobileShopManagement.UserControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pmodel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mfgdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pwaranty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gstprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalamount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalamt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaadhar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtccontact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblsrno = new System.Windows.Forms.Label();
            this.billdate = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.rdbtnfemale = new System.Windows.Forms.RadioButton();
            this.rdbtnmale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.userControl21);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 123);
            this.panel1.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl21.Location = new System.Drawing.Point(155, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1067, 123);
            this.userControl21.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Product Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mobile",
            "Accessaries"});
            this.comboBox1.Location = new System.Drawing.Point(201, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pno,
            this.pname,
            this.pmodel,
            this.mfgdate,
            this.pwaranty,
            this.quantity,
            this.pprice,
            this.total,
            this.gst,
            this.gstprice,
            this.totalamount});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 472);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1303, 142);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pno
            // 
            this.pno.Text = "Product No";
            this.pno.Width = 122;
            // 
            // pname
            // 
            this.pname.Text = "Product Name";
            this.pname.Width = 148;
            // 
            // pmodel
            // 
            this.pmodel.Text = "Product Model";
            this.pmodel.Width = 149;
            // 
            // mfgdate
            // 
            this.mfgdate.Text = "Mfg Date";
            this.mfgdate.Width = 131;
            // 
            // pwaranty
            // 
            this.pwaranty.Text = "Waranty";
            this.pwaranty.Width = 86;
            // 
            // quantity
            // 
            this.quantity.Text = "QTY";
            this.quantity.Width = 47;
            // 
            // pprice
            // 
            this.pprice.Text = "Price";
            this.pprice.Width = 98;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 87;
            // 
            // gst
            // 
            this.gst.Text = "GST %";
            this.gst.Width = 62;
            // 
            // gstprice
            // 
            this.gstprice.Text = "GST_Price(per piece)";
            this.gstprice.Width = 164;
            // 
            // totalamount
            // 
            this.totalamount.Text = "Total_Amount(Inc. all taxes)";
            this.totalamount.Width = 204;
            // 
            // lblqty
            // 
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(1066, 317);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(129, 25);
            this.lblqty.TabIndex = 7;
            this.lblqty.Text = "Enter Quantity : ";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(1201, 313);
            this.txtqty.Multiline = true;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(123, 25);
            this.txtqty.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1065, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Amount :";
            // 
            // lbltotalamt
            // 
            this.lbltotalamt.AutoSize = true;
            this.lbltotalamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamt.Location = new System.Drawing.Point(1195, 637);
            this.lbltotalamt.Name = "lbltotalamt";
            this.lbltotalamt.Size = new System.Drawing.Size(30, 20);
            this.lbltotalamt.TabIndex = 10;
            this.lbltotalamt.Text = "0   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Number :";
            // 
            // lblcno
            // 
            this.lblcno.AutoSize = true;
            this.lblcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcno.Location = new System.Drawing.Point(198, 304);
            this.lblcno.Name = "lblcno";
            this.lblcno.Size = new System.Drawing.Size(90, 16);
            this.lblcno.TabIndex = 12;
            this.lblcno.Text = "       cno             ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer Name :";
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(179, 349);
            this.txtcname.Multiline = true;
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(217, 25);
            this.txtcname.TabIndex = 14;
            this.txtcname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcname_KeyPress);
            // 
            // txtcaddress
            // 
            this.txtcaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaddress.Location = new System.Drawing.Point(179, 415);
            this.txtcaddress.Multiline = true;
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(217, 51);
            this.txtcaddress.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Customer Address :";
            // 
            // txtaadhar
            // 
            this.txtaadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaadhar.Location = new System.Drawing.Point(672, 347);
            this.txtaadhar.MaxLength = 12;
            this.txtaadhar.Multiline = true;
            this.txtaadhar.Name = "txtaadhar";
            this.txtaadhar.Size = new System.Drawing.Size(217, 25);
            this.txtaadhar.TabIndex = 18;
            this.txtaadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaadhar_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer Aadhar :";
            // 
            // txtccontact
            // 
            this.txtccontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccontact.Location = new System.Drawing.Point(672, 413);
            this.txtccontact.MaxLength = 10;
            this.txtccontact.Multiline = true;
            this.txtccontact.Name = "txtccontact";
            this.txtccontact.Size = new System.Drawing.Size(217, 25);
            this.txtccontact.TabIndex = 20;
            this.txtccontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtccontact_KeyPress_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Customer Contact :";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.BackgroundImage")));
            this.btnaddtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddtocart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtocart.Location = new System.Drawing.Point(456, 313);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(120, 25);
            this.btnaddtocart.TabIndex = 4;
            this.btnaddtocart.Text = "Select Product";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuy.BackgroundImage")));
            this.btnbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.Location = new System.Drawing.Point(31, 643);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(120, 25);
            this.btnbuy.TabIndex = 25;
            this.btnbuy.Text = "BUY";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sr.No.";
            // 
            // lblsrno
            // 
            this.lblsrno.AutoSize = true;
            this.lblsrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrno.Location = new System.Drawing.Point(173, 148);
            this.lblsrno.Name = "lblsrno";
            this.lblsrno.Size = new System.Drawing.Size(0, 16);
            this.lblsrno.TabIndex = 28;
            // 
            // billdate
            // 
            this.billdate.CustomFormat = "dd/MM/yyyy";
            this.billdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.billdate.Location = new System.Drawing.Point(201, 198);
            this.billdate.MaxDate = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            this.billdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.billdate.Name = "billdate";
            this.billdate.Size = new System.Drawing.Size(167, 22);
            this.billdate.TabIndex = 29;
            this.billdate.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // btncancel
            // 
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(672, 643);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 25);
            this.btncancel.TabIndex = 30;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // rdbtnfemale
            // 
            this.rdbtnfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnfemale.Location = new System.Drawing.Point(1201, 354);
            this.rdbtnfemale.Name = "rdbtnfemale";
            this.rdbtnfemale.Size = new System.Drawing.Size(94, 25);
            this.rdbtnfemale.TabIndex = 33;
            this.rdbtnfemale.TabStop = true;
            this.rdbtnfemale.Text = "Female";
            this.rdbtnfemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnmale
            // 
            this.rdbtnmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnmale.Location = new System.Drawing.Point(1105, 354);
            this.rdbtnmale.Name = "rdbtnmale";
            this.rdbtnmale.Size = new System.Drawing.Size(67, 25);
            this.rdbtnmale.TabIndex = 32;
            this.rdbtnmale.TabStop = true;
            this.rdbtnmale.Text = "Male";
            this.rdbtnmale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(938, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Customer Gender:";
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(493, 643);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(120, 25);
            this.btnprint.TabIndex = 34;
            this.btnprint.Text = "PRINT BILL";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtbillno
            // 
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillno.Location = new System.Drawing.Point(315, 643);
            this.txtbillno.Multiline = true;
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(143, 25);
            this.txtbillno.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(192, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 35;
            this.label11.Text = "Enter Bill NO :";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.rdbtnfemale);
            this.Controls.Add(this.rdbtnmale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.billdate);
            this.Controls.Add(this.lblsrno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.txtccontact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaadhar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalamt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sell_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControl2 userControl21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pno;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.ColumnHeader pmodel;
        private System.Windows.Forms.ColumnHeader mfgdate;
        private System.Windows.Forms.ColumnHeader pwaranty;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader pprice;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalamt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaadhar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtccontact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblsrno;
        private System.Windows.Forms.DateTimePicker billdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ColumnHeader gst;
        private System.Windows.Forms.ColumnHeader gstprice;
        private System.Windows.Forms.RadioButton rdbtnfemale;
        private System.Windows.Forms.RadioButton rdbtnmale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader totalamount;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label11;
    }
}