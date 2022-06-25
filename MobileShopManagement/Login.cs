using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
namespace MobileShopManagement
{
    public partial class Login : Form
    {
        public static string user;
        public static string randomCode;
        public static string radiobutton;
        public static string to;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Login()
        {
            //string  logintype;
            InitializeComponent();
            user = txtuser.Text.ToString();
            player.SoundLocation = "Alan_Walker_-_Fade_[NCS_Release](256k).wav";
            player.SoundLocation = "Alan_Walker_-_Fade_[NCS_Release](256k).wav";
            
        }
        public static String logintype;
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Length != 0 && txtpass.Text.Length == 0)
            {
                if (MessageBox.Show("Please Enter password","",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
                { 
                }
            }
            else if (txtuser.Text.Length == 0 && txtpass.Text.Length != 0)
            {
                if (MessageBox.Show("Please Enter Username","",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
                { 
                }
            }
            else if(txtuser.Text.Length != 0 && txtpass.Text.Length != 0)
            {
                try
                {
                    if (rdbtnadmin.Checked == true)
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con.Open();
                        string q = "Select username,password from adminlogin where username='" + this.txtuser.Text.ToString() + "' And password='" + this.txtpass.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(q, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (MessageBox.Show("Login Successfully", "Welcome",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
                            {
                                player.PlayLooping();
                                this.Close();
                                MasterScreen ms = new MasterScreen();
                                ms.btnemployee.Show();
                                ms.Show();
                                txtuser.Clear();
                                txtpass.Clear();
                                rdbtnadmin.Checked = false;
                                rdbtnemployee.Checked = false;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid User","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)==DialogResult.OK)
                            {
                                txtuser.Clear();
                                txtpass.Clear();
                                rdbtnadmin.Checked = false;
                                rdbtnemployee.Checked = false;
                            }
                        }
                        con.Close();
                    }
                    else if (rdbtnemployee.Checked == true)
                    {
                        
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con.Open();
                        string q = "Select username,cpassword from userregistration where username='" + this.txtuser.Text.ToString() + "' And cpassword='" + this.txtpass.Text.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(q, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            if (MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                            {
                                player.PlayLooping();
                                this.Close();
                                MasterScreen ms = new MasterScreen();
                                ms.btnemployee.Hide();
                                ms.btnpurchase.Hide();
                                //ms.btnsupplier.Hide();
                                ms.Show();
                                txtuser.Clear();
                                txtpass.Clear();
                                rdbtnadmin.Checked = false;
                                rdbtnemployee.Checked = false;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                txtuser.Clear();
                                txtpass.Clear();
                                rdbtnadmin.Checked = false;
                                rdbtnemployee.Checked = false;
                            }
                        }
                        con.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Please Select Login Type","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
                        { 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }   
            }
            else
            {
                if (MessageBox.Show("Please Enter Username And password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                }
            }
        }
        
        private void Rdbtnadmin_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnadmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPass rp = new ResetPass();
            this.Close();
            rp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnuser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
            this.pictureBox3.Show();
            this.pictureBox2.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '\0';
            this.pictureBox2.Show();
            this.pictureBox3.Hide();
        }

        private void btncancel_Click(object sender, FormClosedEventArgs e)
        {

        }

        private void rdbtnadmin_CheckedChanged_1(object sender, EventArgs e)
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
            if (e.KeyCode == Keys.Tab)
            {
                txtpass.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
