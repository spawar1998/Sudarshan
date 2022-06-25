using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    public partial class Purchase : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
        public Purchase()
        {
            InitializeComponent();       
        }
        private string oid;
        SqlDataAdapter da;
        public string SendData
        {
            get
            {
                return oid;
            }
            set
            {
                oid = value;
            }
        }
        int odetailid,orderid;
        private void Purchase_Load(object sender, EventArgs e)
        {
            btnneworder.Hide();
            podate.CustomFormat = "dd/MM/yyyy";
            podate.MaxDate = DateTime.Today;
            podate.Value = DateTime.Today; 
            podate.Value.Date.ToShortDateString();
            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con2.Open();
            string q2 = "Select max(Order_Id) from OrderHeader";
            SqlCommand cmd2 = new SqlCommand(q2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString() == "")
                {
                    orderid = 1;
                    lbloid.Text = orderid.ToString();
                    txtoid.Text = dr2[0].ToString();
                }
                else
                {
                    orderid = Convert.ToInt16(dr2[0].ToString());
                    lbloid.Text = (orderid + 1).ToString();
                    orderid = Convert.ToInt32(dr2[0].ToString());
                    txtoid.Text = (orderid + 1).ToString();
                }
            }
            con2.Close();
            SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con3.Open();
            string q3 = "Select max(Order_Details_Id) from OrderDetails";
            SqlCommand cmd3 = new SqlCommand(q3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                if (dr3[0].ToString() == "")
                {
                    odetailid = 1;
                }
                else
                {
                    odetailid = Convert.ToInt16(dr3[0].ToString());
                    odetailid = odetailid + 1;
                }
            }
            con3.Close();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Select");
            SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con4.Open();
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select Supplier_Name from Supplier";
            cmd4.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            foreach (DataRow dr4 in dt.Rows)
            {
                comboBox1.Items.Add(dr4["Supplier_Name"].ToString());
            }
            con4.Close();
            //txtoid.Text = lbloid.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Select")
            {
                //MessageBox.Show("Please Select Supplier","",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                lblsid.Text = null;
                lbladdress.Text = null;
                lblcontact.Text = null;
                lblemail.Text = null;
                lblcname.Text = null;
            }
            else
            {
                con.Open();
                string q = "Select Supplier_Id,Supplier_Address,Supplier_Contact,Supplier_Mail,Company_Name from Supplier where Supplier_Name='" + comboBox1.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblsid.Text = dr["Supplier_Id"].ToString();
                    lbladdress.Text = dr["Supplier_Address"].ToString();
                    lblcontact.Text = dr["Supplier_Contact"].ToString();
                    lblemail.Text = dr["Supplier_Mail"].ToString();
                    lblcname.Text = dr["Company_Name"].ToString();
                }
                con.Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Purchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            MasterScreen ms = new MasterScreen();
            ms.Show();
        }

        

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (txtprice.Text.ToString().Length == 0 )
            {
            }
            else
            {
                txttotal.Text = ((Convert.ToDouble(txtquantity.Text.ToString())) * (Convert.ToDouble(txtprice.Text.ToString()))).ToString();
            }
            
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.Text.ToString().Length == 0)
            {
            }
            else
            {
                txttotal.Text = ((Convert.ToDouble(txtquantity.Text.ToString())) * (Convert.ToDouble(txtprice.Text.ToString()))).ToString();
            }
        }
       
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0;i < listView1.Items.Count;i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        lbltotalamt.Text = ((Convert.ToDouble(lbltotalamt.Text.ToString())) - (Convert.ToDouble(listView1.Items[i].SubItems[5].Text))).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void btnclere_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            txtdescreption.Clear();
            txtmodel.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txttotal.Clear();
        }

        private void btnporder_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                if (comboBox2.SelectedIndex >= 0)
                {
                    if (listView1.Items.Count > 0)
                    { 
                        SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con1.Open();
                        string getdata = "Select Supplier_Id from Supplier";
                        SqlCommand cmd1 = new SqlCommand(getdata, con1);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        if (dr1.Read())
                        {
                            string sid = dr1["Supplier_Id"].ToString();

                            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con.Open();
                            string q = "insert into OrderHeader(Order_Id,Order_Date,Total_amt,Supplier_Id)" +
                                "Values('" + this.lbloid.Text.ToString() + "','" + this.podate.Value.ToShortDateString() + "','" + this.lbltotalamt.Text.ToString() + "','" + this.lblsid.Text.ToString() + "')";
                            SqlCommand cmd = new SqlCommand(q, con);
                            SqlDataReader dr;
                            dr = cmd.ExecuteReader();
                            con.Close();

                            SqlConnection con5 = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con5.Open();
                            for (int i = 0; i < listView1.Items.Count; i++)
                            {
                                con5.Close();
                                con5.Open();
                                string q5 = "insert into OrderDetails(Order_Details_Id,Order_Id,Product_Type,Descreption,Product_Model,Quantity,Price,Total)" +
                                "Values('" + this.odetailid.ToString() + "' , '" + this.lbloid.Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[0].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[1].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[2].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[3].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[4].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[5].Text.ToString() + "')";
                                SqlCommand cmd5 = new SqlCommand(q5, con5);
                                SqlDataReader dr5;
                                dr5 = cmd5.ExecuteReader();
                                odetailid ++;
                                con5.Close();
                                con5.Open();
                            }
                            MessageBox.Show("Order Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            btnporder.Hide();
                            btnneworder.Show();
                            con5.Close();

                            
                        }
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Buy At least One product");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Product");
                }
            }
            else
            {
                MessageBox.Show("Please Select Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void podate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void podate_ValueChanged_1(object sender, EventArgs e)
        {
            podate.Format = DateTimePickerFormat.Custom;
            podate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                if (comboBox2.SelectedIndex >= 0)
                {
                    if (this.txtdescreption.Text.ToString().Length != 0 && this.txtmodel.Text.ToString().Length != 0 && this.txtquantity.Text.ToString().Length != 0 && this.txtprice.Text.ToString().Length != 0 && this.txttotal.Text.ToString().Length != 0)
                    {

                        lbltotalamt.Text = (Convert.ToDouble(lbltotalamt.Text) + Convert.ToDouble(txttotal.Text)).ToString();
                        string[] arr = new string[6];
                        arr[0] = this.comboBox2.SelectedItem.ToString();
                        arr[1] = this.txtdescreption.Text.ToString();
                        arr[2] = this.txtmodel.Text.ToString();
                        arr[3] = this.txtquantity.Text.ToString();
                        arr[4] = this.txtprice.Text.ToString();
                        arr[5] = this.txttotal.Text.ToString();
                        ListViewItem lvi = new ListViewItem(arr);
                        listView1.Items.Add(lvi);
                        txtdescreption.Clear();
                        txtmodel.Clear();
                        txtprice.Text = "0";
                        txtquantity.Text = "0";
                        txttotal.Text = "0";

                        
                    }
                    else
                    {
                        MessageBox.Show("Please Fill All Field");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Product Type");
                }
            }
            else
            {
                MessageBox.Show("Please Select Supplier");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltotalamt_Click(object sender, EventArgs e)
        {

        }

        private void btnprintorder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select * from OrderHeader where Order_Id='" + this.txtoid.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {

                }
                else
                {
                    string oid = dr[0].ToString();
                    PurchaseOrder po = new PurchaseOrder(oid);
                    po.Show();
                }
            }
            else
            {
                MessageBox.Show("Order Not Valid");
            }
        }

        private void btnneworder_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con2.Open();
            string q2 = "Select max(Order_Id) from OrderDetails";
            SqlCommand cmd2 = new SqlCommand(q2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString() == "")
                {
                    orderid = 1;
                    lbloid.Text = orderid.ToString();
                    txtoid.Text = "1";
                }
                int orderid1;
                orderid=orderid1= Convert.ToInt16(dr2[0].ToString());
                lbloid.Text = (orderid + 1).ToString();
                txtoid.Text = (orderid1 + 1).ToString();
            }
            con2.Close();
            SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con3.Open();
            string q3 = "Select max(Order_Details_Id) from OrderDetails";
            SqlCommand cmd3 = new SqlCommand(q3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                if (dr3[0].ToString() == "")
                {
                    odetailid = 1;
                }
                odetailid = Convert.ToInt16(dr3[0].ToString());
                odetailid = odetailid + 1;
            }
            con3.Close();
            btnneworder.Hide();
            btnporder.Show();
        }

        private void podate_Click(object sender, EventArgs e)
        {

        }
    }
}
