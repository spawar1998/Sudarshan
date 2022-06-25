namespace MobileShopManagement
{
    partial class SPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtoid = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltransno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblpaymode = new System.Windows.Forms.Label();
            this.lblbillamt = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.lblbalanceamt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpaid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblpending = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnpay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Order Id =";
            // 
            // txtoid
            // 
            this.txtoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoid.Location = new System.Drawing.Point(163, 15);
            this.txtoid.Multiline = true;
            this.txtoid.Name = "txtoid";
            this.txtoid.Size = new System.Drawing.Size(147, 26);
            this.txtoid.TabIndex = 1;
            this.txtoid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoid_KeyPress);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(336, 15);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(88, 26);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date =";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(617, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction no =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bill Amount =";
            // 
            // lbltransno
            // 
            this.lbltransno.AutoSize = true;
            this.lbltransno.BackColor = System.Drawing.Color.Transparent;
            this.lbltransno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransno.Location = new System.Drawing.Point(163, 96);
            this.lbltransno.Name = "lbltransno";
            this.lbltransno.Size = new System.Drawing.Size(66, 18);
            this.lbltransno.TabIndex = 11;
            this.lbltransno.Text = "transano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Payment Mode =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(427, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 18);
            this.label18.TabIndex = 20;
            this.label18.Text = "Enter Amount =";
            // 
            // lblpaymode
            // 
            this.lblpaymode.AutoSize = true;
            this.lblpaymode.BackColor = System.Drawing.Color.Transparent;
            this.lblpaymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymode.Location = new System.Drawing.Point(558, 96);
            this.lblpaymode.Name = "lblpaymode";
            this.lblpaymode.Size = new System.Drawing.Size(69, 18);
            this.lblpaymode.TabIndex = 21;
            this.lblpaymode.Text = "paymode";
            // 
            // lblbillamt
            // 
            this.lblbillamt.AutoSize = true;
            this.lblbillamt.BackColor = System.Drawing.Color.Transparent;
            this.lblbillamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillamt.Location = new System.Drawing.Point(163, 174);
            this.lblbillamt.Name = "lblbillamt";
            this.lblbillamt.Size = new System.Drawing.Size(50, 18);
            this.lblbillamt.TabIndex = 22;
            this.lblbillamt.Text = "billamt";
            // 
            // txtamt
            // 
            this.txtamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamt.Location = new System.Drawing.Point(561, 171);
            this.txtamt.Multiline = true;
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(155, 26);
            this.txtamt.TabIndex = 23;
            this.txtamt.TextChanged += new System.EventHandler(this.txtamt_TextChanged);
            this.txtamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamt_KeyPress);
            // 
            // lblbalanceamt
            // 
            this.lblbalanceamt.AutoSize = true;
            this.lblbalanceamt.BackColor = System.Drawing.Color.Transparent;
            this.lblbalanceamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalanceamt.Location = new System.Drawing.Point(163, 246);
            this.lblbalanceamt.Name = "lblbalanceamt";
            this.lblbalanceamt.Size = new System.Drawing.Size(16, 18);
            this.lblbalanceamt.TabIndex = 25;
            this.lblbalanceamt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Balance Amount =";
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.BackColor = System.Drawing.Color.Transparent;
            this.lblpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.Location = new System.Drawing.Point(558, 246);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(37, 18);
            this.lblpaid.TabIndex = 27;
            this.lblpaid.Text = "Paid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Payment Status =";
            // 
            // lblpending
            // 
            this.lblpending.AutoSize = true;
            this.lblpending.BackColor = System.Drawing.Color.Transparent;
            this.lblpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpending.Location = new System.Drawing.Point(558, 246);
            this.lblpending.Name = "lblpending";
            this.lblpending.Size = new System.Drawing.Size(61, 18);
            this.lblpending.TabIndex = 28;
            this.lblpending.Text = "Pending";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.Transparent;
            this.lblsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(163, 320);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(27, 18);
            this.lblsid.TabIndex = 30;
            this.lblsid.Text = "sid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Supplier Id =";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.Color.Transparent;
            this.lblsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(558, 320);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(53, 18);
            this.lblsname.TabIndex = 32;
            this.lblsname.Text = "sname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Supplier Name =";
            // 
            // btnpay
            // 
            this.btnpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.Location = new System.Drawing.Point(336, 385);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(88, 26);
            this.btnpay.TabIndex = 33;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // SPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.lblsname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblpending);
            this.Controls.Add(this.lblpaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblbalanceamt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.lblbillamt);
            this.Controls.Add(this.lblpaymode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbltransno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtoid);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPayment";
            this.Load += new System.EventHandler(this.SPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltransno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblpaymode;
        private System.Windows.Forms.Label lblbillamt;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label lblbalanceamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblpending;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnpay;
    }
}