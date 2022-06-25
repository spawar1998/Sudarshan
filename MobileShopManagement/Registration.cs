using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    
    public partial class Registration : Form
    {
        
        string randomCode;
        public static string to;
        public Registration()
        {
            //btnregister.Hide();
            InitializeComponent();
        }
        int gridid;
        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //btnexit.Hide();
            txtname.Focus();
            btnaddnew1.Hide();
            BirthDate.CustomFormat = "dd/MM/yyyy";
            BirthDate.Value.Date.ToShortDateString();
            //btnadd.Enabled = false;
            //btnaddnew.Enabled = false;
            int a;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(E_Id) from userregistration";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                { 
                    lbleid.Text = "1";
                }
                else
                {
                    a = Convert.ToInt16(dr[0].ToString());
                    lbleid.Text = (a + 1).ToString();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtname.Text.Length != 0 && txtaddress.Text.Length != 0 && txtcontact.Text.Length != 0 && txtaadhar.Text.Length != 0 && txtmail.Text.Length != 0 && txtuser.Text.Length != 0 && txtpass.Text.Length != 0 && txtcpass.Text.Length != 0 && (rdbtnmale.Checked || rdbtnfemale.Checked) && txtqualification.Text.Length != 0)
            {
                if (txtname.Text.Length > 15)
                {
                    if (txtcontact.Text.Length == 10)
                    {
                        if (txtaadhar.Text.Length == 12)
                        {
                            if (rdbtnmale.Checked || rdbtnfemale.Checked)
                            {
                                if (txtpass.Text == txtcpass.Text)
                                {
                                    if (txtpass.Text.Length >= 8 && txtpass.Text.Length <= 10 && txtcpass.Text.Length >= 8 && txtcpass.Text.Length <= 10)
                                    {
                                        if (txtmail.Text.Length != 0)
                                        {

                                            string email = txtmail.Text;
                                            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                                            Match match = regex.Match(email);
                                            if (match.Success)
                                            {
                                                string sendmail = txtmail.Text.ToString();
                                                string from, pass, messageBody;
                                                Random rand = new Random();
                                                randomCode = (rand.Next(999999)).ToString();
                                                MailMessage message = new MailMessage();
                                                to = sendmail;
                                                from = "spprogrammer1998@gmail.com";
                                                pass = "Sp1991998";
                                                messageBody = "welcome  '" + txtname.Text + "' in om mobile and services " +
                                                    "Your Username is = '" + txtuser.Text + "' And Password is = '" + txtcpass.Text +
                                                    "' your confermation OTP is = " + randomCode;
                                                message.To.Add(to);
                                                message.From = new MailAddress(from);
                                                message.Body = messageBody;
                                                message.Subject = "Registration in Om mobile and services ";
                                                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                                                smtp.EnableSsl = true;
                                                smtp.Port = 587;
                                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                                smtp.UseDefaultCredentials = false;
                                                smtp.EnableSsl = true;
                                                smtp.Credentials = new NetworkCredential(from, pass);
                                                try
                                                {
                                                    smtp.Send(message);
                                                    if (MessageBox.Show("otp send successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                                                    {
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                                    {
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (MessageBox.Show("Please Enter Valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                                {
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (MessageBox.Show("Password Must be at least 8 - 10 character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                                        {
                                        }
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Password Are Missmatch", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                    }
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Select Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Aadhar Number Must be 12 digit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            { 
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Mobile Number Must be 10 digit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        { 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Name .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ('.') && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only allow character","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("Only allow character OR Digit");
            }*/
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclere_Click(object sender, EventArgs e)
        {
            btnaddnew.Enabled = true;
            txtname.Clear();
            txtaddress.Clear();
            txtaadhar.Clear();
            txtcontact.Clear();
            txtmail.Clear();
            txtqualification.Clear();
            txtuser.Clear();
            txtpass.Clear();
            txtcpass.Clear();
            txtotp.Clear();
            rdbtnmale.Checked = false;
            rdbtnfemale.Checked = false;
            BirthDate.Value = BirthDate.MinDate;
            int a;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(E_Id) from userregistration";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    lbleid.Text = "1";
                }
                else
                {
                    a = Convert.ToInt16(dr[0].ToString());
                    lbleid.Text = (a + 1).ToString();
                }
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string Gender = "male";
            if (txtname.Text.Length != 0 && txtaddress.Text.Length != 0 && txtcontact.Text.Length != 0 && txtaadhar.Text.Length != 0 && txtmail.Text.Length != 0 && txtuser.Text.Length != 0 && txtpass.Text.Length != 0 && txtcpass.Text.Length != 0 && (rdbtnmale.Checked || rdbtnfemale.Checked) && txtqualification.Text.Length != 0 && txtotp.Text.Length != 0)
            {
                if (txtname.Text.Length > 15)
                {
                    if (txtcontact.Text.Length == 10)
                    {
                        if (txtaadhar.Text.Length == 12)
                        { 
                            if (rdbtnmale.Checked || rdbtnfemale.Checked)
                            {
                                if (txtpass.Text == txtcpass.Text)
                                {
                                    if (txtpass.Text.Length >= 8 && txtpass.Text.Length <= 10 && txtcpass.Text.Length >= 8 && txtcpass.Text.Length <= 10)
                                    {
                                        if (txtotp.Text.Length != 0)
                                        {
                                            if (randomCode == (txtotp.Text).ToString())
                                            {
                                                if (txtmail.Text.Length != 0)
                                                {
                                                    string email = txtmail.Text;
                                                    Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                                                    Match match = regex.Match(email);
                                                    if (match.Success)
                                                    {
                                                        try
                                                        {
                                                            //con.Close();
                                                            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                            con.Open();
                                                            if (rdbtnmale.Checked)
                                                            {
                                                                Gender = "male";
                                                            }
                                                            if (rdbtnfemale.Checked)
                                                            {
                                                                Gender = "female";
                                                            }
                                                            if (MessageBox.Show("Do You Want To Add Employee", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                                                            {
                                                                //int Bill_No = Convert.ToInt32(txtbillno.Text);
                                                                string eid = lbleid.Text.ToString();
                                                                string UserName = txtuser.Text.ToString();
                                                                string Name = txtname.Text.ToString();
                                                                string Address = txtaddress.Text.ToString();
                                                                string Contact = txtcontact.Text.ToString();
                                                                string Mail = txtmail.Text.ToString();
                                                                string Aadhar = txtaadhar.Text.ToString();
                                                                string Birthdate = BirthDate.Value.ToShortDateString();
                                                                string Qualification = txtqualification.Text.ToString();
                                                                string Pass = txtpass.Text.ToString();
                                                                string Cpass = txtcpass.Text.ToString();
                                                                //string Bill_Date = txtdatebill.Value.ToString();
                                                                //string Total_Amount = txtTAm.Text.ToString();
                                                                string query = "Insert into userregistration(E_Id,username,fullname,contactno,email,aadharno,gender,birthdate,qualification,password,cpassword,address) " +
                                                                "Values('"+ eid +"' , '" + UserName + "','" + Name + "','" + Contact + "','" + Mail + "','" + Aadhar + "','" + Gender + "','" + Birthdate + "','" + Qualification + "','" + Pass + "','" + Cpass + "','" + Address + "')";
                                                                SqlCommand cmd = new SqlCommand(query, con);
                                                                SqlDataReader dr;
                                                                dr = cmd.ExecuteReader();
                                                                if (MessageBox.Show("Add Employee Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                                                                {
                                                                    btnaddnew.Hide();
                                                                    btnaddnew1.Show();
                                                                    //btnadd.Show();
                                                                    txtname.Clear();
                                                                    txtaddress.Clear();
                                                                    txtaadhar.Clear();
                                                                    txtcontact.Clear();
                                                                    txtmail.Clear();
                                                                    txtqualification.Clear();
                                                                    txtuser.Clear();
                                                                    txtpass.Clear();
                                                                    txtcpass.Clear();
                                                                    txtotp.Clear();
                                                                    rdbtnmale.Checked = false;
                                                                    rdbtnfemale.Checked = false;
                                                                    BirthDate.Value = BirthDate.MinDate;

                                                                    int a;
                                                                    SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                                    con2.Open();
                                                                    string q2 = "Select max(E_Id) from userregistration";
                                                                    SqlCommand cmd2 = new SqlCommand(q2, con2);
                                                                    SqlDataReader dr2 = cmd2.ExecuteReader();
                                                                    if (dr2.Read())
                                                                    {
                                                                        if (dr2[0].ToString() == "")
                                                                        {
                                                                            lbleid.Text = "1";
                                                                        }
                                                                        else
                                                                        {
                                                                            a = Convert.ToInt16(dr2[0].ToString());
                                                                            lbleid.Text = (a + 1).ToString();
                                                                        }
                                                                    }
                                                                    //btnadd.Hide();
                                                                    //btnaddnew.Show();
                                                                    con2.Close();
                                                                }
                                                                con.Close();
                                                            }
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Enter Valid mail","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Enter email","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Wrong otp","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Enter Otp","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password Must be at least 8 - 10 character","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password Are Missmatch","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Select Gender","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aadhar Number Must be 12 digit ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mobile Number Must be 10 digit ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Name .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void rdbtnmale_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnmale.ForeColor = System.Drawing.Color.DarkBlue;
            rdbtnfemale.ForeColor = System.Drawing.Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaadhar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void BirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            MasterScreen ms = new MasterScreen();
            this.Close();
            ms.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            String query = "select * from userregistration";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void rdbtnfemale_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnfemale.ForeColor = System.Drawing.Color.DarkBlue;
            rdbtnmale.ForeColor = System.Drawing.Color.Black;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Length != 0 && lbleid.Text.Length != 0)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                if (MessageBox.Show(" Do You Want to Delete!", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "delete from userregistration where fullname ='" + this.txtname.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.ExecuteNonQuery();
                    if (MessageBox.Show("Delete Record Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        txtname.Clear();
                        txtaddress.Clear();
                        txtaadhar.Clear();
                        txtcontact.Clear();
                        txtmail.Clear();
                        txtqualification.Clear();
                        txtuser.Clear();
                        txtpass.Clear();
                        txtcpass.Clear();
                        txtotp.Clear();
                        rdbtnmale.Checked = false;
                        rdbtnfemale.Checked = false;
                        BirthDate.Value = BirthDate.MinDate;
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    con.Close();
            }
            else
            {
                MessageBox.Show("Please enter name","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string gender;
            if (rdbtnmale.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            if (txtname.Text.Length != 0 && txtaddress.Text.Length != 0 && txtcontact.Text.Length != 0 && txtaadhar.Text.Length != 0 && txtmail.Text.Length != 0 && txtuser.Text.Length != 0 && txtpass.Text.Length != 0 && txtcpass.Text.Length != 0 && (rdbtnmale.Checked || rdbtnfemale.Checked) && txtqualification.Text.Length != 0)
            {
                if (txtname.Text.Length > 15)
                {
                    if (txtcontact.Text.Length == 10)
                    {
                        if (txtaadhar.Text.Length == 12)
                        {
                            if (rdbtnmale.Checked || rdbtnfemale.Checked)
                            {
                                if (txtpass.Text == txtcpass.Text)
                                {
                                    if (txtpass.Text.Length >= 8 && txtpass.Text.Length <= 10 && txtcpass.Text.Length >= 8 && txtcpass.Text.Length <= 10)
                                    {
                                        string email = txtmail.Text;
                                        Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                                        Match match = regex.Match(email);
                                        if (match.Success)
                                        {
                                            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                            con.Open();
                                            if (MessageBox.Show("Do You Want Update Record", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                string query = "update userregistration set username='" + this.txtuser.Text + "',fullname='" + this.txtname.Text + "',contactno='" + this.txtcontact.Text + "',email='" + this.txtmail.Text + "', aadharno = '" + this.txtaadhar.Text + "'," +
                                                    "gender = '" + gender + "', birthdate = '" + this.BirthDate.Value.ToShortDateString() + "', qualification = '" + this.txtqualification.Text + "', password = '" + this.txtpass.Text + "', cpassword = '" + this.txtcpass.Text + "', address = '" + this.txtaddress.Text + "' where fullname ='" + this.txtname.Text + "'";
                                                SqlCommand cmd = new SqlCommand(query, con);
                                                cmd.ExecuteNonQuery();
                                                con.Close();
                                                if(MessageBox.Show("Record Updated Successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                                                {
                                                    txtname.Clear();
                                                    txtaddress.Clear();
                                                    txtaadhar.Clear();
                                                    txtcontact.Clear();
                                                    txtmail.Clear();
                                                    txtqualification.Clear();
                                                    txtuser.Clear();
                                                    txtpass.Clear();
                                                    txtcpass.Clear();
                                                    txtotp.Clear();
                                                    rdbtnmale.Checked = false;
                                                    rdbtnfemale.Checked = false;
                                                    BirthDate.Value = BirthDate.MinDate;
                                                }
                                            }
                                           
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Enter Valid email","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password Must be at least 8 - 10 character","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password Are Missmatch","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("PLease Select Gender","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aadhar Number Must be 12 digit ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mobile Number Must be 10 digit","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Fill all field","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtotp.Text.Length != 0)
            {
                if (randomCode == (txtotp.Text).ToString())
                {
                    MessageBox.Show("OTP is verified", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnaddnew.Show();
                }
                else
                {
                    MessageBox.Show("Wrong otp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnaddnew.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Enter otp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnaddnew.Enabled = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            gridid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["E_Id"].Value.ToString());
            string query = "select * from userregistration where E_Id='" + gridid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // txtprodid.Text = dr["ProductID"].ToString();
                lbleid.Text = dr["E_Id"].ToString();
                txtname.Text = dr["fullname"].ToString();
                txtaddress.Text = dr["address"].ToString();
                txtcontact.Text = dr["contactno"].ToString();
                txtmail.Text = dr["email"].ToString();
                BirthDate.Value = Convert.ToDateTime(dr["birthdate"].ToString());
                BirthDate.Value.Date.ToShortDateString();
                txtaadhar.Text = dr["aadharno"].ToString();
                txtqualification.Text = dr["qualification"].ToString();
                txtpass.Text = dr["password"].ToString();
                txtcpass.Text = dr["cpassword"].ToString();
                txtuser.Text = dr["username"].ToString();
                string gender = dr["gender"].ToString();
                if (gender == "male")
                {
                    rdbtnmale.Checked = true;
                }
                else if (gender == "female")
                {
                    rdbtnfemale.Checked = true;
                }
            }
            con.Close();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MasterScreen ms = new MasterScreen();
            
            ms.Show();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddnew1_Click(object sender, EventArgs e)
        {
            int a;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(E_Id) from userregistration";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    lbleid.Text = "1";
                }
                else
                {
                    a = Convert.ToInt16(dr[0].ToString());
                    lbleid.Text = (a + 1).ToString();
                }
            }
            btnaddnew1.Hide();
            btnaddnew.Show();
        }

        

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.txtaadhar.SelectionStart = 0;
                txtaadhar.Focus();
            }
        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmail.Focus();
            }
        }

        private void txtmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaadhar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BirthDate.Focus();
            }
        }

        private void BirthDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtqualification.Focus();
            }
        }

        private void txtqualification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtuser.Focus();
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
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

        private void txtcpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtotp.Focus();
            }
        }

        private void txtname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontact.Focus();
            }
        }

        private void Registration_CursorChanged(object sender, EventArgs e)
        {

        }

        private void Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                
            }
        }

        private void txtaddress_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void txtaddress_AcceptsTabChanged(object sender, EventArgs e)
        {
            txtaadhar.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
