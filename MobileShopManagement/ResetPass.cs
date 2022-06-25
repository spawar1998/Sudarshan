using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
namespace MobileShopManagement
{
    public partial class ResetPass : Form
    {

        public static string randomCode;
        public static string to;
        
        public ResetPass()
        {
            InitializeComponent();
            
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            //Login l = new Login();
            string rcode = Login.randomCode;
            if (txtuser.Text.Length != 0)
            {
                if (rcode == (txtuser.Text).ToString())
                {
                    MessageBox.Show("OTP is verified","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                   
                }
                else
                {
                    MessageBox.Show("Wrong otp","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                  
                }
            }
            else
            {
                MessageBox.Show("Please Enter otp","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtotp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
             //   e.Handled = true;
              //  MessageBox.Show("Only Digit allow","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Length != 0 && txtpass.Text.Length != 0 && txtcpass.Text.Length != 0)
            {

                try
                {
                    Login l = new Login();
                    string username = Login.user.ToString();
                    // string user = l.txtuser.Text;
                    if (txtpass.Text.Length >= 8 && txtpass.Text.Length <= 10 && txtcpass.Text.Length >= 8 && txtcpass.Text.Length <= 10)
                    {
                        if (this.txtotp.Text.Length != 0)
                        {
                            if (randomCode == (txtotp.Text).ToString())
                            {
                                if (txtpass.Text == txtcpass.Text)
                                {
                                    
                                    if (rdbtnadmin.Checked)
                                    {

                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string query = "update adminlogin set password='" + this.txtcpass.Text.ToString() + "' where username ='" + this.txtuser.Text.ToString() + "'";
                                        SqlCommand cmd = new SqlCommand(query, con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Password Reset Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                  
                                    }
                                    else if (rdbtnemployee.Checked)
                                    {
                                        //string user = l.txtuser.Text.ToString();
                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string query = "update userregistration set password='" + txtpass.Text.ToString() + "',cpassword='" + this.txtcpass.Text.ToString() + "' where username='" + this.txtuser.Text.ToString() + "' ";
                                        SqlCommand cmd = new SqlCommand(query, con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Password Resest Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Select Login Type","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Password Are Missmatch","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong otp","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter otp","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Must be 8-10 digit","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill The Field ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.txtuser.Text.Length != 0)
                {

                    if (this.rdbtnadmin.Checked)
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con.Open();
                        string q = "Select * from adminlogin where username ='" + this.txtuser.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(q, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string userdata = Convert.ToString(dr["username"]);
                            if (this.txtuser.Text.ToString() == userdata)
                            {
                                string mail = Convert.ToString(dr["username"]);
                                string from, pass, messageBody;
                                Random rand = new Random();
                                randomCode = (rand.Next(999999)).ToString();
                                MailMessage message = new MailMessage();
                                to = mail;
                                from = "spprogrammer1998@gmail.com";
                                pass = "Sp@1991998";
                                messageBody = "your one time password is = " + randomCode;
                                message.To.Add(to);
                                message.From = new MailAddress(from);
                                message.Body = messageBody;
                                message.Subject = "password reseting code";
                                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                                smtp.EnableSsl = true;
                                //smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Port = 587;
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Credentials = new NetworkCredential(from, pass);
                                smtp.Send(message);
                                MessageBox.Show("Otp Send Successfully On Your Register Mail", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    else if (this.rdbtnemployee.Checked)
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select * from userregistration where username ='" + this.txtuser.Text.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string userdata = Convert.ToString(dr["username"]);
                            if (this.txtuser.Text.ToString() == userdata)
                            {
                                string mail = Convert.ToString(dr["email"]);
                                string from, pass, messageBody;
                                Random rand = new Random();
                                randomCode = (rand.Next(999999)).ToString();
                                MailMessage message = new MailMessage();
                                to = mail;
                                from = "spprogrammer1998@gmail.com";
                                pass = "sp1991998";
                                messageBody = "your one time password is = " + randomCode;
                                message.To.Add(to);
                                message.From = new MailAddress(from);
                                message.Body = messageBody;
                                message.Subject = "password reseting code";
                                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                                smtp.EnableSsl = true;
                                smtp.Port = 587;
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Credentials = new NetworkCredential(from, pass);
                                smtp.Send(message);
                                MessageBox.Show("Otp Send Successfully On Your Register Mail", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Login Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SmtpException se)
            {
                if (MessageBox.Show(se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                }
            }
        }

        private void rdbtnadmin_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnadmin.ForeColor = System.Drawing.Color.DarkBlue;
            rdbtnemployee.ForeColor = System.Drawing.Color.Black;
        }

        private void rdbtnemployee_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnemployee.ForeColor = System.Drawing.Color.DarkBlue;
            rdbtnadmin.ForeColor = System.Drawing.Color.Black;
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtotp.Focus();
            }
        }

        private void txtotp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcpass.Focus();
            }
        }
    }
}
