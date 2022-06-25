namespace MobileShopManagement
{
    partial class ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbtnadmin = new System.Windows.Forms.RadioButton();
            this.rdbtnemployee = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtotp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(151, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "OM MOBILE AND SERVICES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 95);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Court ,Near Bus Stand,Collage Road,Chandwad";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter OTP :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Password :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Confirm Password :";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(251, 345);
            this.txtpass.MaxLength = 10;
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(137, 36);
            this.txtpass.TabIndex = 13;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged_1);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtcpass
            // 
            this.txtcpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpass.Location = new System.Drawing.Point(640, 345);
            this.txtcpass.MaxLength = 10;
            this.txtcpass.Multiline = true;
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.ShortcutsEnabled = false;
            this.txtcpass.Size = new System.Drawing.Size(142, 36);
            this.txtcpass.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreset.BackgroundImage")));
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(98, 440);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(125, 36);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter Username :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select User Type";
            // 
            // rdbtnadmin
            // 
            this.rdbtnadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnadmin.Location = new System.Drawing.Point(284, 177);
            this.rdbtnadmin.Name = "rdbtnadmin";
            this.rdbtnadmin.Size = new System.Drawing.Size(94, 34);
            this.rdbtnadmin.TabIndex = 20;
            this.rdbtnadmin.TabStop = true;
            this.rdbtnadmin.Text = "Admin";
            this.rdbtnadmin.UseVisualStyleBackColor = true;
            this.rdbtnadmin.CheckedChanged += new System.EventHandler(this.rdbtnadmin_CheckedChanged);
            // 
            // rdbtnemployee
            // 
            this.rdbtnemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnemployee.Location = new System.Drawing.Point(411, 176);
            this.rdbtnemployee.Name = "rdbtnemployee";
            this.rdbtnemployee.Size = new System.Drawing.Size(129, 36);
            this.rdbtnemployee.TabIndex = 21;
            this.rdbtnemployee.TabStop = true;
            this.rdbtnemployee.Text = "Employee";
            this.rdbtnemployee.UseVisualStyleBackColor = true;
            this.rdbtnemployee.CheckedChanged += new System.EventHandler(this.rdbtnemployee_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(600, 181);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 23);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SEND OTP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(352, 111);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(295, 36);
            this.txtuser.TabIndex = 23;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // txtotp
            // 
            this.txtotp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.Location = new System.Drawing.Point(251, 252);
            this.txtotp.MaxLength = 6;
            this.txtotp.Multiline = true;
            this.txtotp.Name = "txtotp";
            this.txtotp.Size = new System.Drawing.Size(137, 36);
            this.txtotp.TabIndex = 24;
            this.txtotp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtotp_KeyDown);
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 538);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rdbtnemployee);
            this.Controls.Add(this.rdbtnadmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.Load += new System.EventHandler(this.ResetPass_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbtnadmin;
        private System.Windows.Forms.RadioButton rdbtnemployee;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtotp;
    }
}