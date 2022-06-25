namespace MobileShopManagement
{
    partial class CustomerPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblcash = new System.Windows.Forms.Label();
            this.visa = new System.Windows.Forms.PictureBox();
            this.mastercard = new System.Windows.Forms.PictureBox();
            this.discover = new System.Windows.Forms.PictureBox();
            this.americanexpress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastercard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.americanexpress)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ok";
            // 
            // lblcash
            // 
            this.lblcash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(205, 274);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(382, 26);
            this.lblcash.TabIndex = 2;
            this.lblcash.Text = "                       Cash";
            this.lblcash.Click += new System.EventHandler(this.lblcash_Click);
            // 
            // visa
            // 
            this.visa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visa.Image = ((System.Drawing.Image)(resources.GetObject("visa.Image")));
            this.visa.Location = new System.Drawing.Point(205, 164);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(91, 55);
            this.visa.TabIndex = 3;
            this.visa.TabStop = false;
            this.visa.Click += new System.EventHandler(this.visa_Click);
            // 
            // mastercard
            // 
            this.mastercard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mastercard.Image = ((System.Drawing.Image)(resources.GetObject("mastercard.Image")));
            this.mastercard.Location = new System.Drawing.Point(302, 164);
            this.mastercard.Name = "mastercard";
            this.mastercard.Size = new System.Drawing.Size(91, 55);
            this.mastercard.TabIndex = 4;
            this.mastercard.TabStop = false;
            this.mastercard.Click += new System.EventHandler(this.mastercard_Click);
            // 
            // discover
            // 
            this.discover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discover.Image = ((System.Drawing.Image)(resources.GetObject("discover.Image")));
            this.discover.Location = new System.Drawing.Point(399, 164);
            this.discover.Name = "discover";
            this.discover.Size = new System.Drawing.Size(91, 55);
            this.discover.TabIndex = 5;
            this.discover.TabStop = false;
            this.discover.Click += new System.EventHandler(this.discover_Click);
            // 
            // americanexpress
            // 
            this.americanexpress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.americanexpress.Image = ((System.Drawing.Image)(resources.GetObject("americanexpress.Image")));
            this.americanexpress.Location = new System.Drawing.Point(496, 164);
            this.americanexpress.Name = "americanexpress";
            this.americanexpress.Size = new System.Drawing.Size(91, 55);
            this.americanexpress.TabIndex = 6;
            this.americanexpress.TabStop = false;
            this.americanexpress.Click += new System.EventHandler(this.americanexpress_Click);
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.americanexpress);
            this.Controls.Add(this.discover);
            this.Controls.Add(this.mastercard);
            this.Controls.Add(this.visa);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPayment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastercard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.americanexpress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.PictureBox visa;
        private System.Windows.Forms.PictureBox mastercard;
        private System.Windows.Forms.PictureBox discover;
        private System.Windows.Forms.PictureBox americanexpress;
    }
}