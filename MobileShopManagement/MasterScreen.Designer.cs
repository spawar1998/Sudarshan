namespace MobileShopManagement
{
    partial class MasterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopmusic = new System.Windows.Forms.LinkLabel();
            this.startmusic = new System.Windows.Forms.LinkLabel();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.btnstock = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.lbllogout = new System.Windows.Forms.LinkLabel();
            this.btnemployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl21 = new MobileShopManagement.UserControl2();
            this.btnpayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.btnpayment);
            this.panel1.Controls.Add(this.stopmusic);
            this.panel1.Controls.Add(this.startmusic);
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btnsupplier);
            this.panel1.Controls.Add(this.btnsale);
            this.panel1.Controls.Add(this.btnstock);
            this.panel1.Controls.Add(this.btnpurchase);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 67);
            this.panel1.TabIndex = 1;
            // 
            // stopmusic
            // 
            this.stopmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopmusic.Location = new System.Drawing.Point(1202, 21);
            this.stopmusic.Name = "stopmusic";
            this.stopmusic.Size = new System.Drawing.Size(156, 27);
            this.stopmusic.TabIndex = 10;
            this.stopmusic.TabStop = true;
            this.stopmusic.Text = "STOP MUSIC";
            this.stopmusic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stopmusic_LinkClicked);
            // 
            // startmusic
            // 
            this.startmusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startmusic.Location = new System.Drawing.Point(1202, 21);
            this.startmusic.Name = "startmusic";
            this.startmusic.Size = new System.Drawing.Size(156, 27);
            this.startmusic.TabIndex = 9;
            this.startmusic.TabStop = true;
            this.startmusic.Text = "START MUSIC";
            this.startmusic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startmusic_LinkClicked);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnreports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreports.BackgroundImage")));
            this.btnreports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreports.Location = new System.Drawing.Point(942, -1);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(136, 67);
            this.btnreports.TabIndex = 7;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnsupplier
            // 
            this.btnsupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsupplier.BackgroundImage")));
            this.btnsupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsupplier.Location = new System.Drawing.Point(292, 0);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(136, 67);
            this.btnsupplier.TabIndex = 6;
            this.btnsupplier.Text = "Supplier";
            this.btnsupplier.UseVisualStyleBackColor = false;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click_1);
            this.btnsupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsupplier_KeyDown);
            // 
            // btnsale
            // 
            this.btnsale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsale.BackgroundImage")));
            this.btnsale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsale.Location = new System.Drawing.Point(684, -1);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(136, 67);
            this.btnsale.TabIndex = 4;
            this.btnsale.Text = "Sale";
            this.btnsale.UseVisualStyleBackColor = false;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnstock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstock.BackgroundImage")));
            this.btnstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstock.Location = new System.Drawing.Point(553, -1);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(136, 67);
            this.btnstock.TabIndex = 3;
            this.btnstock.Text = "Stock";
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnpurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpurchase.BackgroundImage")));
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpurchase.Location = new System.Drawing.Point(423, -1);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(136, 67);
            this.btnpurchase.TabIndex = 2;
            this.btnpurchase.Text = "Purchase";
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllogout
            // 
            this.lbllogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.Location = new System.Drawing.Point(1084, 20);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(112, 27);
            this.lbllogout.TabIndex = 1;
            this.lbllogout.TabStop = true;
            this.lbllogout.Text = "LOG OUT";
            this.lbllogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnemployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnemployee.BackgroundImage")));
            this.btnemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnemployee.Location = new System.Drawing.Point(164, -1);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(136, 67);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.btnregister_Click);
            this.btnemployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnemployee_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1375, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl21.Location = new System.Drawing.Point(164, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1067, 123);
            this.userControl21.TabIndex = 0;
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnpayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpayment.BackgroundImage")));
            this.btnpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpayment.Location = new System.Drawing.Point(813, -1);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(136, 67);
            this.btnpayment.TabIndex = 5;
            this.btnpayment.Text = "Payment";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // MasterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl21);
            this.Name = "MasterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MasterScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl2 userControl21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbllogout;
        public System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnpurchase;
        public System.Windows.Forms.Button btnsale;
        public System.Windows.Forms.Button btnstock;
        public System.Windows.Forms.Button btnreports;
        public System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.LinkLabel startmusic;
        private System.Windows.Forms.LinkLabel stopmusic;
        public System.Windows.Forms.Button btnpayment;
    }
}