using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        long gridid;
        double total1 , gst1;
        string gender,shopno;
        int cid, srno, cbillno;
        float discount = 0;
        public void showmobile()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select imeino1,imeino2,model,company,MFG_date,waranty,price,gst,Sell_Price from StockMobile";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void showaccessaries()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select Product_No,Product_Name,Product_Model,MFG_date,waranty,QTY,Price,Total,GST,sellprice from StockAccessaries";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblqty.Hide();
                txtqty.Hide();
                showmobile();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lblqty.Show();
                txtqty.Show();
                showaccessaries();
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select QTY from StockAccessaries";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int qty = Convert.ToInt32(dr[0].ToString());
                    if (qty == 0)
                    {
                        SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con1.Open();
                        string q1 = "delete from StockAccessaries where QTY = '"+ Convert.ToInt32(0) +"'";
                    }   
                }
            }
            else
            {
                MessageBox.Show("Please Select Product", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gridid = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["imeino1"].Value.ToString());
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gridid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Product_No"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Product");
            }
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            billdate.CustomFormat = "dd/MM/yyyy";
            billdate.MaxDate = DateTime.Today;
            billdate.Value = DateTime.Today;
            billdate.Value.Date.ToShortDateString();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select Max(Customer_Id) from Customer";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    cid = 1;
                    lblcno.Text = cid.ToString();
                }
                else
                {
                    cid = Convert.ToInt32(dr[0].ToString());
                    cid++;
                    lblcno.Text = cid.ToString();
                }
            }
            con.Close();

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con1.Open();
            string q1 = "Select Max(sr_no) from Cbilldetails";
            SqlCommand cmd1 = new SqlCommand(q1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                if (dr1[0].ToString() == "")
                {
                    srno = 1;
                }
                else
                {
                    srno = Convert.ToInt32(dr1[0].ToString());
                    srno++;
                }
            }
            con1.Close();

            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con2.Open();
            string q2 = "Select Max(c_bill_no) from Cbillheader";
            SqlCommand cmd2 = new SqlCommand(q2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString() == "")
                {
                    cbillno = 1;
                    txtbillno.Text = "1";
                    lblsrno.Text = "1";
                }
                else
                {
                    int billno;
                    cbillno=billno= Convert.ToInt32(dr2[0].ToString());
                    cbillno++;
                    lblsrno.Text = cbillno.ToString();
                    billno++;
                    txtbillno.Text = billno.ToString();
                }
            }
            con.Close();
            lblqty.Hide();
            txtqty.Hide();
        }

        private void txtcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ('.') && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only allow character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtccontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtccontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbtnmale_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnmale.ForeColor = System.Drawing.Color.BlueViolet;
            rdbtnfemale.ForeColor = System.Drawing.Color.Black;
        }

        private void txtaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtccontact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select * from Cbillheader where c_bill_no='" + this.txtbillno.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() != "")
                {
                    Bill b = new Bill(this.txtbillno.Text.ToString());
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (this.lblcno.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.txtcaddress.Text.ToString().Length != 0 && this.txtaadhar.Text.ToString().Length != 0 && this.txtccontact.Text.ToString().Length != 0 && ((this.rdbtnmale.Checked) || (this.rdbtnfemale.Checked)))
                    {
                        if (this.txtccontact.Text.ToString().Length == 10)
                        {
                            if (this.txtaadhar.Text.ToString().Length == 12)
                            {
                                if (gridid.ToString().Length != 0)
                                {
                                    if (MessageBox.Show("Do You Want To Confirm Buy Product", "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string q = "Select imeino1,imeino2,model,company,MFG_date,waranty,price,gst,Sell_Price from StockMobile where imeino1='" + this.gridid + "'";
                                        SqlCommand cmd = new SqlCommand(q, con);
                                        SqlDataReader dr = cmd.ExecuteReader();
                                        if (dr.Read())
                                        {

                                            double gst,gstprice;
                                            gst = Convert.ToDouble(dr["gst"].ToString());
                                            gst = 0.01 * gst;

                                            gstprice = gst * Convert.ToDouble(dr["price"].ToString());

                                            string[] arr = new string[11];
                                            arr[0] = dr["imeino1"].ToString();
                                            arr[1] = "Mobile";
                                            arr[2] = dr["model"].ToString();
                                            DateTime date = Convert.ToDateTime(dr["MFG_date"].ToString());
                                            arr[3] = date.ToShortDateString();
                                            arr[4] = dr["waranty"].ToString();
                                            arr[5] = "1";
                                            arr[6] = dr["price"].ToString();
                                            arr[7] = dr["Price"].ToString();
                                            arr[8] = dr["gst"].ToString();
                                            arr[9] = gstprice.ToString();
                                            arr[10] = dr["Sell_Price"].ToString();
                                            ListViewItem lvi = new ListViewItem(arr);
                                            listView1.Items.Add(lvi);

                                            lbltotalamt.Text = ((Convert.ToDouble(this.lbltotalamt.Text.ToString())) + (Convert.ToDouble(dr["Sell_Price"].ToString()))).ToString();

                                            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                            con1.Open();
                                            string q1 = "delete from StockMobile where imeino1='" + this.gridid + "'";
                                            SqlCommand cmd1 = new SqlCommand(q1, con1);
                                            cmd1.ExecuteNonQuery();
                                            showmobile();
                                            con1.Close();
                                        }
                                        con.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Select Product GridView", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aadhar Number must be 12 digit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mobile number must be 10 digit", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill Customer Detail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Product", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (this.lblcno.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.txtcaddress.Text.ToString().Length != 0 && this.txtaadhar.Text.ToString().Length != 0 && this.txtccontact.Text.ToString().Length != 0 && ((this.rdbtnmale.Checked) || (this.rdbtnfemale.Checked)))
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        if (this.txtccontact.Text.ToString().Length == 10)
                        {
                            if (this.txtaadhar.Text.ToString().Length == 12)
                            {
                                if (gridid.ToString().Length != 0)
                                {
                                    if (txtqty.Text.ToString().Length != 0)
                                    {
                                        int Qty;
                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string q = "Select Product_No,Product_Name,Product_Model,MFG_date,waranty,QTY,Price,Total,GST,GST_Amount,GST_Total_Amount,sellprice from StockAccessaries where Product_No = '" + this.gridid + "'";
                                        SqlCommand cmd = new SqlCommand(q, con);
                                        SqlDataReader dr;
                                        dr = cmd.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            Qty = Convert.ToInt32(dr["QTY"].ToString());
                                            if (Qty >= 1)
                                            {
                                                if (Qty >= Convert.ToDouble(this.txtqty.Text.ToString()))
                                                {
                                                    if (MessageBox.Show("Do You Want To Confirm Buy This Product", "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                    {
                                                        double price, price1, gstprice, totalprice, totalgst;
                                                        price = Convert.ToDouble(dr["sellprice"].ToString());
                                                        price1 = Convert.ToDouble(dr["Price"].ToString());

                                                        total1 = Convert.ToDouble((Convert.ToInt32(this.txtqty.Text.ToString())) * (price1));

                                                        gst1 = Convert.ToDouble(dr["GST"].ToString());
                                                        gst1 = 0.01 * gst1;

                                                        totalgst = Convert.ToDouble(Convert.ToInt32(txtqty.Text.ToString()) * (Convert.ToDouble(price)));

                                                        gstprice = Convert.ToDouble((0.01 * Convert.ToDouble(dr["GST"].ToString())) * (price1));


                                                        totalprice = total1 + gstprice;

                                                        string[] arr = new string[11];
                                                        arr[0] = dr["Product_No"].ToString();
                                                        arr[1] = dr["Product_Name"].ToString();
                                                        arr[2] = dr["Product_Model"].ToString();
                                                        DateTime date = Convert.ToDateTime(dr["MFG_date"].ToString());
                                                        arr[3] = date.ToShortDateString();
                                                        arr[4] = dr["waranty"].ToString();
                                                        arr[5] = this.txtqty.Text.ToString();
                                                        arr[6] = dr["Price"].ToString();
                                                        arr[7] = total1.ToString();
                                                        arr[8] = dr["GST"].ToString();
                                                        arr[9] = gstprice.ToString();
                                                        arr[10] = totalgst.ToString();

                                                        ListViewItem lvi = new ListViewItem(arr);
                                                        listView1.Items.Add(lvi);

                                                        //lbltotalamt.Text = Convert.ToString((Convert.ToDouble(this.lbltotalamt.Text.ToString())) + (total1.ToString())).ToString();

                                                        lbltotalamt.Text = Convert.ToString(Convert.ToDouble(lbltotalamt.Text) + (Convert.ToDouble(Convert.ToInt32(txtqty.Text.ToString()) * (Convert.ToDouble(price)))));

                                                        SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                        con1.Open();
                                                        string q1 = "update StockAccessaries set QTY=QTY-'" + this.txtqty.Text.ToString() + "',Total=Total-'" + total1.ToString() + "' where Product_No='" + this.gridid + "'";
                                                        SqlCommand cmd1 = new SqlCommand(q1, con1);
                                                        cmd1.ExecuteNonQuery();
                                                        con1.Close();
                                                        showaccessaries();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Quantity is high", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Product Not Available");
                                                SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                con1.Open();
                                                string q1 = "delete from StockAccessaries where Product_No='" + this.gridid + "'";
                                                SqlCommand cmd1 = new SqlCommand(q1, con1);
                                                cmd1.ExecuteNonQuery();
                                                showaccessaries();
                                                con1.Close();
                                            }
                                            con.Close();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter Quantity", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Select Product in datagriview", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aadhar number must be 12 digit", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mobile number must be 10 digit ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Product","",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Customer Details", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select Product Type", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void rdbtnfemale_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnfemale.ForeColor = System.Drawing.Color.BlueViolet;
            rdbtnmale.ForeColor = System.Drawing.Color.Black;
        }
        private void btnbuy_Click_1(object sender, EventArgs e)
        {
            if (this.lblcno.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.txtcaddress.Text.ToString().Length != 0 && this.txtaadhar.Text.ToString().Length != 0 && this.txtccontact.Text.ToString().Length != 0 && ((this.rdbtnmale.Checked) || (this.rdbtnfemale.Checked)))
            {
                if (this.txtccontact.Text.ToString().Length == 10)
                {
                    if (this.txtaadhar.Text.ToString().Length == 12)
                    {
                        if (listView1.Items.Count > 0)
                        {
                            if (MessageBox.Show("Do You Want To Confirm to Buy this product", "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                con1.Open();
                                string getdata = "Select Shop_No from MobileShop";
                                SqlCommand cmd1 = new SqlCommand(getdata, con1);
                                SqlDataReader dr1 = cmd1.ExecuteReader();
                                if (dr1.Read())
                                {
                                    shopno = dr1["Shop_No"].ToString();
                                    if (this.lblcno.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.txtcaddress.Text.ToString().Length != 0 && this.txtaadhar.Text.ToString().Length != 0 && this.txtccontact.Text.ToString().Length != 0 && ((this.rdbtnmale.Checked = true) || (this.rdbtnfemale.Checked = true)))
                                    {
                                        if (rdbtnmale.Checked)
                                        {
                                            gender = "Male";
                                        }
                                        else if (rdbtnfemale.Checked)
                                        {
                                            gender = "Female";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Select Gender", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                        }

                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string q = "Insert into Customer(Customer_Id,Customer_Name,Customer_Address,Customer_Aadhar,Customer_Contact,Customer_Gender,s_no)" +
                                                        "Values('" + this.lblcno.Text.ToString() + "' , '" + this.txtcname.Text.ToString() + "' , '" + this.txtcaddress.Text.ToString() + "' , '" + this.txtaadhar.Text.ToString() + "' , '" + this.txtccontact.Text.ToString() + "' , '" + gender + "' , '" + shopno + "')";
                                        SqlCommand cmd = new SqlCommand(q, con);
                                        SqlDataReader dr;
                                        dr = cmd.ExecuteReader();
                                        con.Close();

                                        SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con3.Open();
                                        string q3 = "insert into Cbillheader(c_bill_no,c_bill_date,c_bill_totalamt,Discount,c_bill_finalamt,customer_id,SNO)" +
                                            "Values('" + this.cbillno.ToString() + "' , '" + this.billdate.Value.ToShortDateString() + "' , '" + this.lbltotalamt.Text.ToString() + "' , '" + this.discount.ToString() + "' , '" + this.lbltotalamt.Text.ToString() + "' , '" + this.lblcno.Text.ToString() + "' , '" + this.shopno.ToString() + "')";
                                        SqlCommand cmd3 = new SqlCommand(q3, con3);
                                        SqlDataReader dr3;
                                        dr3 = cmd3.ExecuteReader();
                                        con3.Close();


                                        SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con2.Open();
                                        for (int i = 0; i < listView1.Items.Count; i++)
                                        {
                                            con2.Close();
                                            con2.Open();
                                            string q2 = "insert into Cbilldetails(sr_no,Product_No,product_name,Model,mfg_date,waranty,quantity,rate,total,GST,GST_Price,Total_Amount_inc_Taxes,c_bill_no)" +
                                            "Values('" + this.srno.ToString() + "' , '" + this.listView1.Items[i].SubItems[0].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[1].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[2].Text.ToString() + "' , '" + Convert.ToDateTime(this.listView1.Items[i].SubItems[3].Text.ToString()).ToShortDateString() + "' , '" + this.listView1.Items[i].SubItems[4].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[5].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[6].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[7].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[8].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[9].Text.ToString() + "' , '" + this.listView1.Items[i].SubItems[10].Text.ToString() + "' , '" + this.cbillno.ToString() + "')";
                                            SqlCommand cmd2 = new SqlCommand(q2, con2);
                                            SqlDataReader dr2;
                                            dr2 = cmd2.ExecuteReader();
                                            srno++;
                                            con2.Close();
                                            con2.Open();
                                        }
                                        btnbuy.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill Customer Detail", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Add Product To cart", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aadhar Number Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mobile Number Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Customer Details","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    } 
}
