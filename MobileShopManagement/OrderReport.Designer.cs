namespace MobileShopManagement
{
    partial class OrderReport
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
            this.mindate = new System.Windows.Forms.DateTimePicker();
            this.maxdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btndisplayall = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnsupplierorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mindate
            // 
            this.mindate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mindate.CustomFormat = "dd/MM/yyyy";
            this.mindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mindate.Location = new System.Drawing.Point(147, 14);
            this.mindate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mindate.Name = "mindate";
            this.mindate.Size = new System.Drawing.Size(99, 20);
            this.mindate.TabIndex = 0;
            this.mindate.Value = new System.DateTime(2020, 4, 26, 0, 0, 0, 0);
            // 
            // maxdate
            // 
            this.maxdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxdate.CustomFormat = "dd/MM/yyyy";
            this.maxdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.maxdate.Location = new System.Drawing.Point(388, 14);
            this.maxdate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.maxdate.Name = "maxdate";
            this.maxdate.Size = new System.Drawing.Size(99, 20);
            this.maxdate.TabIndex = 1;
            this.maxdate.Value = new System.DateTime(2020, 4, 26, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date : ";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(542, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(65, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1372, 694);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // btndisplayall
            // 
            this.btndisplayall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplayall.Location = new System.Drawing.Point(1199, 11);
            this.btndisplayall.Name = "btndisplayall";
            this.btndisplayall.Size = new System.Drawing.Size(135, 23);
            this.btndisplayall.TabIndex = 6;
            this.btndisplayall.Text = "Display All Order";
            this.btndisplayall.UseVisualStyleBackColor = true;
            this.btndisplayall.Click += new System.EventHandler(this.btndisplayall_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(807, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnsupplierorder
            // 
            this.btnsupplierorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplierorder.Location = new System.Drawing.Point(1031, 11);
            this.btnsupplierorder.Name = "btnsupplierorder";
            this.btnsupplierorder.Size = new System.Drawing.Size(135, 23);
            this.btnsupplierorder.TabIndex = 8;
            this.btnsupplierorder.Text = "Display Order";
            this.btnsupplierorder.UseVisualStyleBackColor = true;
            this.btnsupplierorder.Click += new System.EventHandler(this.btnsupplierorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Supplier Name";
            // 
            // OrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsupplierorder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btndisplayall);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxdate);
            this.Controls.Add(this.mindate);
            this.Name = "OrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OrderReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker mindate;
        private System.Windows.Forms.DateTimePicker maxdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btndisplayall;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnsupplierorder;
        private System.Windows.Forms.Label label3;
    }
}