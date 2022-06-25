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
using System.Text.RegularExpressions;

namespace MobileShopManagement
{
    public partial class Supplier : Form
    {
        int sid;
        string shopno;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
        public Supplier()
        {
            InitializeComponent();
        }
        int gridid;
        public void View()
        {
            con.Open();
            String query = "Select Supplier_Id,Supplier_Name,Supplier_Address,Supplier_Contact,Supplier_Mail,Company_Name from Supplier";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            con.Close();
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            txtsid.Focus();
            btnaddnew.Hide();
            btnadd.Show();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(Supplier_Id) from Supplier";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    sid = 1;
                    txtsid.Text = "1";
                }
                else
                {
                    sid = Convert.ToInt16(dr[0].ToString());
                    txtsid.Text = (sid + 1).ToString();
                }
            }

            con.Close();
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ('.') && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only allow character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ('.') && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only allow character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            View();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con1.Open();
            string getdata = "Select Shop_No from MobileShop";
            SqlCommand cmd1 = new SqlCommand(getdata, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                shopno = dr1["Shop_No"].ToString();
                if (txtsid.Text.ToString().Length != 0 && txtsname.Text.ToString().Length != 0 && txtaddress.Text.ToString().Length != 0 && txtcontact.Text.ToString().Length != 0 && txtmail.Text.ToString().Length != 0 && txtcname.Text.ToString().Length != 0)
                {
                    if (txtcontact.Text.ToString().Length == 10)
                    {
                        if (txtmail.Text.Length != 0)
                        {
                            string email = txtmail.Text.ToString();
                            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                            Match match = regex.Match(email);
                            if (match.Success)
                            {
                                if (MessageBox.Show("Do You Want Add Supplier ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                                {
                                    con.Open();
                                    String query = "Insert into Supplier(Supplier_Id,Supplier_Name,Supplier_Address,Supplier_Contact,Supplier_Mail,Company_Name,ShopNo)" +
                                        "Values('" + txtsid.Text.ToString() + "' , '" + txtsname.Text.ToString() + "' , '" + txtaddress.Text.ToString() + "' , '" + txtcontact.Text.ToString() + "' , '" + txtmail.Text.ToString() + "' , '" + txtcname.Text.ToString() + "' , '"+ this.shopno+"')";
                                    SqlCommand cmd = new SqlCommand(query, con);
                                    SqlDataReader dr;
                                    dr = cmd.ExecuteReader();
                                    if (MessageBox.Show("Supplier Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                                    {
                                        
                                        txtsname.Clear();
                                        txtaddress.Clear();
                                        txtcontact.Clear();
                                        txtmail.Clear();
                                        txtcname.Clear();
                                        btnadd.Hide();
                                        btnaddnew.Show();
                                    }
                                    con.Close();
                                    View();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter Valid Mail", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mobile Number must be 10 digit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            int sid;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(Supplier_Id) from Supplier";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    txtsid.Text = "1";
                }
                else
                {
                    sid = Convert.ToInt16(dr[0].ToString());
                    txtsid.Text = (sid + 1).ToString();
                }
            }
            con.Close();
            btnaddnew.Hide();
            btnadd.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnadd.Enabled = false;
            btnaddnew.Enabled = false;
            con.Open();
            gridid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Supplier_Id"].Value.ToString());
            string query = "select * from Supplier where Supplier_Id='" + gridid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtsid.Text = dr["Supplier_Id"].ToString();
                txtsname.Text = dr["Supplier_Name"].ToString();
                txtaddress.Text = dr["Supplier_Address"].ToString();
                txtcontact.Text = dr["Supplier_Contact"].ToString();
                txtmail.Text = dr["Supplier_Mail"].ToString();
                txtcname.Text = dr["Company_Name"].ToString();
            }
            con.Close();
        }

        private void btnclere_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            btnaddnew.Enabled = true;
            txtsid.Clear();
            txtsname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtmail.Clear();
            txtcname.Clear();
            int sid;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(Supplier_Id) from Supplier";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    txtsid.Text = "1";
                }
                else
                {
                    sid = Convert.ToInt16(dr[0].ToString());
                    txtsid.Text = (sid + 1).ToString();
                }
            }
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtsid.Text.Length != 0 && txtsname.Text.Length != 0 && txtaddress.Text.Length != 0 && txtcontact.Text.Length != 0 && txtmail.Text.Length != 0 && txtcname.Text.Length != 0)
            {
                if (MessageBox.Show(" Do You Want to Delete!", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "delete from Supplier where Supplier_Id ='" + this.txtsid.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.ExecuteNonQuery();
                    if (MessageBox.Show("Delete Record Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {

                        txtsname.Clear();
                        txtaddress.Clear();
                        txtcontact.Clear();
                        txtmail.Clear();
                        txtcname.Clear();
                        con.Close();
                    }
                    View();
                }
            }
            else
            {
                if (MessageBox.Show("Record Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                { }
            }
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtsid.Text.ToString().Length != 0 && txtsname.Text.ToString().Length != 0 && txtaddress.Text.ToString().Length != 0 && txtcontact.Text.ToString().Length != 0 && txtmail.Text.ToString().Length != 0 && txtcname.Text.ToString().Length != 0)
            {
                if (txtcontact.Text.ToString().Length == 10)
                {
                    if (txtmail.Text.Length != 0)
                    {
                        string email = txtmail.Text.ToString();
                        Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                        Match match = regex.Match(email);
                        if (match.Success)
                        {
                            con.Open();
                            if (MessageBox.Show("Do You Want Update Record", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                       
                                string query = "update Supplier set Supplier_Id='" + this.txtsid.Text + "',Supplier_Name='" + this.txtsname.Text + "',Supplier_Address='" + this.txtaddress.Text + "',Supplier_Contact='" + this.txtcontact.Text + "',Supplier_Mail='" + this.txtmail.Text + "',Company_Name= '" + this.txtcname.Text + "' where Supplier_Id='"+this.txtsid.Text.ToString()+"'";
                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                if (MessageBox.Show("Record Updated Successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                                {
                                   
                                    txtsname.Clear();
                                    txtaddress.Clear();
                                    txtcontact.Clear();
                                    txtmail.Clear();
                                    txtcname.Clear();
                                }
                                View();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Mail", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mobile Number must be 10 digit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsname.Focus();
            }
        }

        private void txtsname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontact.Focus();
            }
        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtmail.Focus();
            }
        }

        private void txtmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcname.Focus();
            }
        }
    }
}
