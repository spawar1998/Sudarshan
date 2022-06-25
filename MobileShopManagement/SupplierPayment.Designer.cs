namespace MobileShopManagement
{
    partial class SupplierPayment
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
            this.lblcash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcash
            // 
            this.lblcash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(205, 281);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(382, 26);
            this.lblcash.TabIndex = 8;
            this.lblcash.Text = "                       Cash";
            this.lblcash.Click += new System.EventHandler(this.lblcash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ok";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "                 Bank Transfer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SupplierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SupplierPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierPayment";
            this.Load += new System.EventHandler(this.SupplierPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}