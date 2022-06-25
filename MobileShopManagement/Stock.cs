using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    public partial class Stock : Form
    {
        int gridheaderid, griddetailid, pno;
        long gridid;


        public Stock()
        {
            InitializeComponent();
        }
        public void viewstock()
        {
            if (comboBox1.SelectedItem.ToString() == "Select")
            { 
            
            }
            if (comboBox1.SelectedItem.ToString() == "Mobile")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select imeino1,imeino2,model,company,MFG_date,waranty,price,gst,total,Sell_Price from StockMobile";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                SDA.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessaries")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select Product_No,Product_Name,Product_Model,MFG_date,waranty,QTY,Price,Total,GST,GST_Amount,sellprice,GST_Total_Amount from StockAccessaries";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                SDA.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select Product Type");
            }
        }
        public void Vieworderdetail()
        {
            if (this.txtoid.Text.ToString().Length != 0)
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                con1.Open();
                string q1 = "Select Order_Details_Id,OrderHeader.Order_Id,Order_Date,Product_Type,Descreption,Product_Model,Quantity,Price,Total from OrderDetails,OrderHeader where Product_Type = '" + comboBox1.Text.ToString() + "' and OrderHeader.Order_Id='" + this.txtoid.Text.ToString() + "' and OrderDetails.Order_Id='" + this.txtoid.Text.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con1);
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter SDA1 = new SqlDataAdapter(cmd1);
                SDA1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con1.Close();
            }
            else
            {
                MessageBox.Show("Please Enter order Id");
            }
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            mmfgdate.CustomFormat = "dd/MM/yyyy";
            pmfgdate.CustomFormat = "dd/MM/yyyy";
            mmfgdate.MaxDate = DateTime.Today;
            pmfgdate.MaxDate = DateTime.Today;
            mmfgdate.Value = DateTime.Today;
            pmfgdate.Value = DateTime.Today;
            mmfgdate.Value.Date.ToShortDateString();
            pmfgdate.Value.Date.ToShortDateString();
            lblsname.Hide();
            btnaddstock.Show();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select max(Product_No) from StockAccessaries";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    pno = 1;
                }
                else
                {
                    pno = Convert.ToInt16(dr[0].ToString());
                    pno++;
                }
            }
            /*this.comboBox1.SelectedIndex = 0;
            lblimei1.Visible = true;
            lblimei2.Visible = true;
            lblmodel.Visible = true;
            lblcname.Visible = true;
            lblmmfgdate.Visible = true;
            lblmwaranty.Visible = true;
            lblmprice.Visible = true;
            lblmyear.Visible = true;
            lblmsprice.Visible = true;
            lblpmodel.Visible = false;
            lblpname.Visible = false;
            lblpmfgdate.Visible = false;
            lblqty.Visible = false;
            lblpprice.Visible = false;
            lblpsprice.Visible = false;
            lblpwaranty.Visible = false;
            lbltotal.Visible = false;
            lblpyear.Visible = false;
            txtimei1.Visible = true;
            txtimei2.Visible = true;
            txtmodel.Visible = true;
            txtcname.Visible = true;
            mmfgdate.Visible = true;
            txtmwaranty.Visible = true;
            txtmprice.Visible = true;
            txtmsellprice.Visible = true;
            txtpmodel.Visible = false;
            txtpname.Visible = false;
            pmfgdate.Visible = false;
            txtpwaranty.Visible = false;
            txtqty.Visible = false;
            txtpsellprice.Visible = false;
            txtpprice.Visible = false;
            txttotal.Visible = false;
            */
            //btnaddstock.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblgsttotal.Visible = false;
                txtgsttotal.Visible = false;
                lblimei1.Visible = false;
                lblimei2.Visible = false;
                lblmodel.Visible = false;
                lblcname.Visible = false;
                lblmmfgdate.Visible = false;
                lblmwaranty.Visible = false;
                lblmprice.Visible = false;
                lblmsprice.Visible = false;
                lblmyear.Visible = false;
                txtimei1.Visible = false;
                txtimei2.Visible = false;
                txtmodel.Visible = false;
                txtcname.Visible = false;
                mmfgdate.Visible = false;
                txtmwaranty.Visible = false;
                txtmprice.Visible = false;
                txtmsellprice.Visible = false;
                //btnaddstock.Visible = false;
                lblpmodel.Visible = false;
                lblpname.Visible = false;
                lblpmfgdate.Visible = false;
                lblqty.Visible = false;
                lblpprice.Visible = false;
                lblpsprice.Visible = false;
                lblpwaranty.Visible = false;
                lbltotal.Visible = false;
                lblpyear.Visible = false;
                txtpmodel.Visible = false;
                txtpname.Visible = false;
                pmfgdate.Visible = false;
                txtpwaranty.Visible = false;
                txtqty.Visible = false;
                txtpsellprice.Visible = false;
                txtpprice.Visible = false;
                txttotal.Visible = false;
                lblgsttotal.Visible = false;
                txtgst.Visible = false;
                txtgsttotal.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                txttotalamount.Visible = false;
                txtgst.Clear();
                txttotalamount.Clear();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = true;
                lblgsttotal.Visible = false;
                txtgsttotal.Visible = false;
                lblimei1.Visible = true;
                label3.Visible = true;
                txttotalamount.Visible = true;
                lblimei2.Visible = true;
                lblmodel.Visible = true;
                lblcname.Visible = true;
                lblmmfgdate.Visible = true;
                lblmwaranty.Visible = true;
                lblmprice.Visible = true;
                lblmsprice.Visible = true;
                lblmyear.Visible = true;
                txtimei1.Visible = true;
                txtimei2.Visible = true;
                txtmodel.Visible = true;
                txtcname.Visible = true;
                mmfgdate.Visible = true;
                txtmwaranty.Visible = true;
                txtmprice.Visible = true;
                txtmsellprice.Visible = true;
                btnaddstock.Visible = true;
                lblpmodel.Visible = false;
                lblpname.Visible = false;
                lblpmfgdate.Visible = false;
                lblqty.Visible = false;
                lblpprice.Visible = false;
                lblpsprice.Visible = false;
                lblpwaranty.Visible = false;
                lbltotal.Visible = false;
                lblpyear.Visible = false;
                txtpmodel.Visible = false;
                txtpname.Visible = false;
                pmfgdate.Visible = false;
                txtpwaranty.Visible = false;
                txtqty.Visible = false;
                txtpsellprice.Visible = false;
                txtpprice.Visible = false;
                txttotal.Visible = false;
                txtgst.Clear();
                txttotalamount.Clear();
                txtgst.Visible = true;
                txttotalamount.Visible = true;
                Vieworderdetail();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Visible = true;
                lblgsttotal.Visible = true;
                txtgsttotal.Visible = true;
                lblpmodel.Visible = true;
                lblpname.Visible = true;
                lblpmfgdate.Visible = true;
                lblqty.Visible = true;
                lblpprice.Visible = true;
                lblpsprice.Visible = true;
                lblpwaranty.Visible = true;
                lbltotal.Visible = true;
                lblpyear.Visible = true;
                txtpmodel.Visible = true;
                label3.Visible = true;
                txttotalamount.Visible = true;
                txtpname.Visible = true;
                pmfgdate.Visible = true;
                txtpwaranty.Visible = true;
                txtqty.Visible = true;
                txtpsellprice.Visible = true;
                txtpprice.Visible = true;
                txttotal.Visible = true;
                btnaddstock.Visible = true;
                lblimei1.Visible = false;
                lblimei2.Visible = false;
                lblmodel.Visible = false;
                lblcname.Visible = false;
                lblmmfgdate.Visible = false;
                lblmwaranty.Visible = false;
                lblmprice.Visible = false;
                lblmyear.Visible = false;
                lblmsprice.Visible = false;
                txtimei1.Visible = false;
                txtimei2.Visible = false;
                txtmodel.Visible = false;
                txtcname.Visible = false;
                mmfgdate.Visible = false;
                txtmwaranty.Visible = false;
                txtmprice.Visible = false;
                txtmsellprice.Visible = false;
                txtgst.Clear();
                txttotalamount.Clear();
                Vieworderdetail();
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }


            /*int removeduplicate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            for (int i = 0; i <= Convert.ToInt32(dataGridView1.SelectedRows.Count - 1); i++)
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()) == removeduplicate)
                {
                    dataGridView1.SelectedRows[i].Cells[0].Value = string.Empty;
                }
                else
                {
                    removeduplicate = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                }
            }*/
            /*foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
            if (row.Index == this.dataGridView1.CurrentCell.RowIndex)
            {
                continue;
            }
            if (this.dataGridView1.CurrentCell.Value == null)
            {
                continue;
            }
            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == dataGridView1.CurrentCell.Value.ToString())
            {
                dataGridView1.CurrentCell.Value = null;
            }
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { 
            
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                gridheaderid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_Id"].Value.ToString());
                griddetailid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_Details_Id"].Value.ToString());
                string query = "select OrderDetails.Order_Id,Order_Date,Product_Type,Descreption,Product_Model,Price from OrderDetails,OrderHeader where Order_Details_Id='" + this.griddetailid + "' and OrderHeader.Order_Id=OrderDetails.Order_Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    mmfgdate.Value = Convert.ToDateTime(dr["Order_Date"].ToString());
                    mmfgdate.Value.Date.ToShortDateString();
                    txtmprice.Text = dr["Price"].ToString();
                    txtmodel.Text = dr["Product_Model"].ToString();
                }
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                gridheaderid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_Id"].Value.ToString());
                griddetailid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_Details_Id"].Value.ToString());

                string query = "select Order_Id,Product_Type,Descreption,Product_Model,Quantity,Price,Total from OrderDetails where Order_Details_Id='" + griddetailid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtpprice.Text = dr["Price"].ToString();
                    txtpmodel.Text = dr["Product_Model"].ToString();
                    txtpname.Text = dr["Descreption"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong");
            }
        }

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please Select Order Product to add in stock");
            }
            else
            {
                if (this.comboBox1.SelectedItem.ToString() == "Select")
                {
                }
                else if (this.comboBox1.SelectedItem.ToString() == "Mobile")
                {
                    DateTime Date;
                    int qty;
                    double totalamt;
                    SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con3.Open();
                    string q3 = "Select Order_Date,Quantity,Total_amt from OrderDetails,OrderHeader where OrderDetails.Order_Details_Id='" + this.griddetailid + "' and OrderHeader.Order_Id='" + this.gridheaderid + "' and OrderDetails.Order_Id=OrderHeader.Order_Id";
                    SqlCommand cmd3 = new SqlCommand(q3, con3);
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        Date = Convert.ToDateTime(dr3["Order_Date"].ToString());
                        qty = Convert.ToInt32(dr3["Quantity"].ToString());
                        totalamt = Convert.ToDouble(dr3["Total_amt"].ToString());
                        if (qty > 0)
                        {
                            if (Date > Convert.ToDateTime(this.mmfgdate.Value))
                            {
                                if (totalamt > 0)
                                {
                                    if (this.txtimei1.Text.ToString().Length != 0 && this.txtimei2.Text.ToString().Length != 0 && this.txtmodel.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.mmfgdate.Value.ToString().Length != 0 && this.txtmwaranty.Text.ToString().Length != 0 && this.txtmsellprice.Text.ToString().Length != 0 && this.txtgst.Text.ToString().Length != 0 && this.txttotalamount.Text.ToString().Length != 0)
                                    {
                                        if (this.txtimei1.Text.ToString().Length >= 14 && this.txtimei1.Text.ToString().Length <= 15 && this.txtimei2.Text.ToString().Length >= 14 && this.txtimei2.Text.ToString().Length <= 15)
                                        {
                                            if (Convert.ToDouble(this.txttotalamount.Text.ToString()) < Convert.ToDouble(this.txtmsellprice.Text.ToString()))
                                            {
                                                if (MessageBox.Show("Do You Want To Add Stock", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                {
                                                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                    con1.Open();
                                                    string getdata = "Select Shop_no from MobileShop";
                                                    SqlCommand cmd1 = new SqlCommand(getdata, con1);
                                                    SqlDataReader dr1 = cmd1.ExecuteReader();
                                                    if (dr1.Read())
                                                    {
                                                        string sno = dr1["Shop_No"].ToString();
                                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                        con.Open();
                                                        string q = "insert into StockMobile(imeino1,imeino2,model,company,MFG_date,waranty,price,gst,total,Sell_Price,Shop_No)" +
                                                            "Values('" + this.txtimei1.Text.ToString() + "','" + this.txtimei2.Text.ToString() + "','" + this.txtmodel.Text.ToString() + "','" + this.txtcname.Text.ToString() + "' , '" + this.mmfgdate.Value.ToShortDateString() + "' , '" + this.txtmwaranty.Text.ToString() + "' , '" + this.txtmprice.Text.ToString() + "' , '" + this.txtgst.Text.ToString() + "' , '" + this.txttotalamount.Text.ToString() + "' , '" + this.txtmsellprice.Text.ToString() + "' , '" + sno.ToString() + "')";
                                                        SqlCommand cmd = new SqlCommand(q, con);
                                                        SqlDataReader dr;
                                                        dr = cmd.ExecuteReader();
                                                        con.Close();

                                                        SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                        con2.Open();
                                                        string q2 = "update OrderDetails set Quantity=Quantity-1,Total=Total-'" + this.txtmprice.Text + "' where Order_Details_Id='" + this.griddetailid.ToString() + "'";
                                                        SqlCommand cmd2 = new SqlCommand(q2, con2);
                                                        cmd2.ExecuteNonQuery();
                                                        con2.Close();

                                                        SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                        con4.Open();
                                                        string q4 = "update OrderHeader set Total_amt=Total_amt-'" + this.txtmprice.Text.ToString() + "'where Order_Id='" + this.gridheaderid.ToString() + "'";
                                                        SqlCommand cmd4 = new SqlCommand(q4, con4);
                                                        cmd4.ExecuteNonQuery();
                                                        con4.Close();

                                                        btnviewstock_Click(sender, e);
                                                        Vieworderdetail();
                                                        MessageBox.Show("Stock Added Successfully");

                                                    }
                                                    con1.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Sell price must be greater", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("IMEI No must be 14 to 15 digit only", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter all value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    SqlConnection con5 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                    con5.Open();
                                    string q5 = "delete from OrderHeader where Order_Id ='" + this.gridheaderid + "'";
                                    SqlCommand cmd5 = new SqlCommand(q5, con5);
                                    cmd5.ExecuteNonQuery();
                                    Vieworderdetail();
                                    con5.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("MFG Date are Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mobile Not Available");
                            SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con4.Open();
                            string q4 = "delete from OrderDetails where Order_Details_Id ='" + this.griddetailid + "'";
                            SqlCommand cmd4 = new SqlCommand(q4, con4);
                            cmd4.ExecuteNonQuery();
                            Vieworderdetail();
                            con4.Close();
                        }
                    }
                    con3.Close();
                }
                else if (comboBox1.SelectedItem.ToString() == "Accessaries")
                {
                    DateTime Date;
                    int qty;
                    double totalamt, price;
                    SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con3.Open();
                    string q3 = "Select Order_Date,Quantity,Price,Total_amt from OrderDetails,OrderHeader where OrderDetails.Order_Details_Id='" + this.griddetailid + "' and OrderHeader.Order_Id='" + this.gridheaderid + "' and OrderDetails.Order_Id=OrderHeader.Order_Id and Product_Type = '" + comboBox1.SelectedItem.ToString() + "'";
                    SqlCommand cmd3 = new SqlCommand(q3, con3);
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        Date = Convert.ToDateTime(dr3["Order_Date"].ToString());
                        Date.Date.ToShortDateString();
                        qty = Convert.ToInt32(dr3["Quantity"].ToString());
                        totalamt = Convert.ToDouble(dr3["Total_amt"].ToString());
                        price = Convert.ToDouble(dr3["Price"].ToString());
                        if (qty > 0)
                        {
                            if (totalamt > 0)
                            {
                                if (Date > Convert.ToDateTime(this.pmfgdate.Value))
                                {
                                    if (this.pno.ToString().Length != 0 && this.txtpmodel.Text.ToString().Length != 0 && this.txtpname.Text.ToString().Length != 0 && this.pmfgdate.Value.ToString().Length != 0 && this.txtpprice.Text.ToString().Length != 0 && this.txtqty.Text.ToString().Length != 0 && this.txttotal.Text.ToString().Length != 0 && this.txtpwaranty.Text.Length != 0 && this.txtpsellprice.Text.ToString().Length != 0)
                                    {
                                        if (Convert.ToDouble(this.txtpwaranty.Text.ToString()) > 0)
                                        {
                                            if (Convert.ToInt32(this.txtqty.Text.ToString()) > 0)
                                            {
                                                if (Convert.ToDouble(this.txtpsellprice.Text.ToString()) > Convert.ToDouble(this.txtpprice.Text.ToString()))
                                                {
                                                    if (Convert.ToDouble(this.txttotal.Text.ToString()) > 0)
                                                    {
                                                        if (qty >= Convert.ToInt32(this.txtqty.Text.ToString()))
                                                        {
                                                            if (MessageBox.Show("Do You Want To Add Stock", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                            {
                                                                SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                                con1.Open();
                                                                string getdata = "Select Shop_no from MobileShop";
                                                                SqlCommand cmd1 = new SqlCommand(getdata, con1);
                                                                SqlDataReader dr1 = cmd1.ExecuteReader();
                                                                if (dr1.Read())
                                                                {
                                                                    string sno = dr1["Shop_No"].ToString();

                                                                    SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                                    con.Open();
                                                                    string q = "insert into StockAccessaries(Product_No,Product_Name,Product_Model,MFG_date,waranty,QTY,Price,Total,GST,GST_Amount,sellprice,GST_Total_Amount,Shop_no)" +
                                                                        "Values('" + this.pno + "' , '" + this.txtpname.Text.ToString() + "','" + this.txtpmodel.Text.ToString() + "','" + this.pmfgdate.Value.ToShortDateString() + "','" + this.txtpwaranty.Text + "' , '" + this.txtqty.Text + "' , '" + this.txtpprice.Text + "' , '" + this.txttotal.Text + "' , '" + this.txtgst.Text + "' , '" + this.txttotalamount.Text + "' , '" + this.txtpsellprice.Text.ToString() + "' , '" + this.txtgsttotal.Text.ToString() + "' , '" + sno + "')";
                                                                    SqlCommand cmd = new SqlCommand(q, con);
                                                                    SqlDataReader dr = cmd.ExecuteReader();
                                                                    con.Close();

                                                                    SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                                    con2.Open();
                                                                    string q2 = "update OrderDetails set Quantity=Quantity-'" + this.txtqty.Text.ToString() + "',Total=Total-'" + this.txttotal.Text.ToString() + "' where Order_Details_Id='" + this.griddetailid.ToString() + "'";
                                                                    SqlCommand cmd2 = new SqlCommand(q2, con2);
                                                                    cmd2.ExecuteNonQuery();
                                                                    con2.Close();

                                                                    SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                                                    con4.Open();
                                                                    string q4 = "update OrderHeader set Total_amt=Total_amt-'" + this.txttotal.Text.ToString() + "'  where Order_Id='" + this.gridheaderid.ToString() + "'";
                                                                    SqlCommand cmd4 = new SqlCommand(q4, con4);
                                                                    cmd4.ExecuteNonQuery();
                                                                    con4.Close();

                                                                    MessageBox.Show("Stock Add Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                                                    pno++;

                                                                    Vieworderdetail();
                                                                    viewstock();

                                                                }
                                                                con1.Close();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Invalid Quantity");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Invalid Total");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Price Invalid");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Quantity Invalid");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Waranty Invalid");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter All Value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("MFG Date are Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                SqlConnection con5 = new SqlConnection(Properties.Settings.Default.sqlcon);
                                con5.Open();
                                string q5 = "delete from OrderHeader where Order_Id ='" + this.gridheaderid + "'";
                                SqlCommand cmd5 = new SqlCommand(q5, con5);
                                cmd5.ExecuteNonQuery();
                                Vieworderdetail();
                                con5.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product Not Available");
                            SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con4.Open();
                            string q4 = "delete from OrderDetails where Order_Details_Id ='" + this.griddetailid + "'";
                            SqlCommand cmd4 = new SqlCommand(q4, con4);
                            cmd4.ExecuteNonQuery();
                            Vieworderdetail();
                            con4.Close();
                        }
                    }
                    con3.Close();
                }
                else
                {
                    MessageBox.Show("Somthing Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtimei1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtimei1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtimei2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
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

        private void txtsellprice_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void lblpname_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (this.txtpprice.Text.ToString().Length != 0)
            {
                if (this.txtqty.Text.ToString().Length == 0)
                {
                    txttotal.Clear();
                }
                else
                {
                    txttotal.Text = (Convert.ToInt32(this.txtqty.Text.ToString()) * Convert.ToDouble(this.txtpprice.Text.ToString())).ToString();
                }
            }
            else
            {
               
            }
        }

        private void txtpsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpwaranty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtpprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnviewstock_Click(object sender, EventArgs e)
        {
            viewstock();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Select")
            { 
            }
            else if (comboBox1.SelectedItem.ToString() == "Mobile")
            {

                if (this.txtimei1.Text.ToString().Length != 0 && this.txtimei2.Text.ToString().Length != 0 && this.txtmodel.Text.ToString().Length != 0 && this.txtcname.Text.ToString().Length != 0 && this.mmfgdate.Value.ToString().Length != 0 && this.txtmwaranty.Text.ToString().Length != 0 && this.txtmsellprice.Text.ToString().Length != 0)
                {
                    if (this.txtimei1.Text.ToString().Length >= 14 && this.txtimei1.Text.ToString().Length <= 15 && this.txtimei2.Text.ToString().Length >= 14 && this.txtimei2.Text.ToString().Length <= 15)
                    {

                        if (MessageBox.Show("Do you want to update stock", "Confirmation message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con.Open();
                            string query = "update StockMobile set  imeino1='" + this.txtimei1.Text.ToString() + "' , imeino2='" + this.txtimei2.Text.ToString() + "' , model='" + this.txtmodel.Text.ToString() + "' , company='" + this.txtcname.Text.ToString() + "' , MFG_date='" + this.mmfgdate.Value.ToShortDateString() + "' , waranty='" + this.txtmwaranty.Text.ToString() + "' , price='" + this.txtmprice.Text.ToString() + "' , gst='" + this.txtgst.Text.ToString() + "' , total='" + this.txttotalamount.Text.ToString() + "' , Sell_Price='" + this.txtmsellprice.Text.ToString() + "' where imeino1='" + this.gridid + "'";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Stock Updated Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("IMEI No must be 14 to 15 digit only", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Accessaries")
            {
                if (this.txtpmodel.Text.ToString().Length != 0 && this.txtpname.Text.ToString().Length != 0 && this.pmfgdate.Value.ToString().Length != 0 && this.txtpprice.Text.ToString().Length != 0 && this.txtqty.Text.ToString().Length != 0 && this.txttotal.Text.ToString().Length != 0 && this.txtpwaranty.Text.Length != 0 && this.txtpsellprice.Text.ToString().Length != 0)
                {
                    if (Convert.ToDouble(this.txtpwaranty.Text.ToString()) > 0)
                    {
                        if (Convert.ToInt32(this.txtqty.Text.ToString()) > 0)
                        {
                            if (Convert.ToDouble(this.txtpprice.Text.ToString()) > 0)
                            {
                                if (Convert.ToDouble(this.txttotal.Text.ToString()) > 0)
                                {

                                    if (MessageBox.Show("Do You Want To Update Stock", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                                        con.Open();
                                        string query = "update StockAccessaries set Product_Name='" + this.txtpname.Text.ToString() + "' , Product_Model='" + this.txtpmodel.Text.ToString() + "' , MFG_date='" + this.pmfgdate.Value.ToShortDateString() + "' , waranty='" + this.txtpwaranty.Text.ToString() + "' , QTY='" + this.txtqty.Text.ToString() + "' , Price='" + this.txtpprice.Text.ToString() + "' , Total='" + this.txttotal.Text.ToString() + "' , GST='" + this.txtgst.Text.ToString() + "' , GST_Amount='" + this.txttotalamount.Text.ToString() + "' , GST_Total_Amount='" + this.txtgsttotal.Text.ToString() + "' , sellprice='" + this.txtpsellprice.Text.ToString() + "' where Product_No='" + this.gridid + "'";
                                        SqlCommand cmd = new SqlCommand(query, con);
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Stock Updated Successfully","",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                                        con.Close();
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Total", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Price Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantity Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Waranty Invalid", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter All Value", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                        
            }
            else
            {
                MessageBox.Show("Somthing went wrong","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                btnaddstock.Enabled = false;
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                gridid = Convert.ToInt64(dataGridView2.Rows[e.RowIndex].Cells["imeino1"].Value.ToString());
                string query = "select * from StockMobile where imeino1='" + this.gridid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtimei1.Text = dr["imeino1"].ToString();
                    txtimei2.Text = dr["imeino2"].ToString();
                    txtmodel.Text = dr["model"].ToString();
                    txtcname.Text = dr["company"].ToString();
                    DateTime date = Convert.ToDateTime(dr["MFG_date"].ToString());
                    mmfgdate.Text = date.ToShortDateString();
                    txtmwaranty.Text = dr["waranty"].ToString();
                    txtmprice.Text = dr["price"].ToString();
                    txtmsellprice.Text = dr["Sell_Price"].ToString();
                    txtgst.Text = dr["gst"].ToString();
                    txttotalamount.Text = dr["total"].ToString();
                }
                con.Close();
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                con1.Open();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                btnaddstock.Enabled = false;
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();

                gridid = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Product_No"].Value.ToString());
                
                string query = "select * from StockAccessaries where Product_No='" + this.gridid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtpname.Text = dr["Product_Name"].ToString();
                    txtpmodel.Text = dr["Product_Model"].ToString();
                    DateTime date = Convert.ToDateTime(dr["MFG_date"].ToString());
                    pmfgdate.Text = date.ToShortDateString();
                    txtpwaranty.Text = dr["waranty"].ToString();
                    txtqty.Text = dr["QTY"].ToString();
                    txtpprice.Text = dr["Price"].ToString();
                    txttotal.Text = dr["Total"].ToString();
                    txtpsellprice.Text = dr["sellprice"].ToString();
                    txtgst.Text = dr["GST"].ToString();
                    txttotalamount.Text = dr["GST_Amount"].ToString();
                    txtgsttotal.Text = dr["GST_Total_Amount"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtgst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttotalamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ('.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtgst_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Select")
            { 
            
            }
            else if (comboBox1.SelectedItem.ToString() == "Mobile")
            {
                if (this.txtgst.Text.ToString().Length == 0)
                {
                    txtgst.Clear();
                }
                else
                {
                    Double gst = 0.01 * (Convert.ToDouble(this.txtgst.Text.ToString()));
                    Double totalgst = gst * Convert.ToDouble(this.txtmprice.Text.ToString());
                    Double total = totalgst + Convert.ToDouble(this.txtmprice.Text.ToString());
                    txttotalamount.Text = Convert.ToString(total);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessaries")
            {
                if (this.txtpprice.Text.ToString().Length == 0)
                {
                    txtpprice.Clear();
                }
                else
                {
                    double gst = 0.01 * (Convert.ToDouble(this.txtgst.Text.ToString()));
                    double totalgst = gst * Convert.ToDouble(this.txtpprice.Text.ToString());
                    double total = totalgst + Convert.ToDouble(this.txtpprice.Text.ToString());
                    txttotalamount.Text = Convert.ToString(total);
                }
                if (this.txttotal.Text.ToString().Length == 0)
                {
                }
                else
                {
                    double gst = 0.01 * (Convert.ToDouble(this.txtgst.Text.ToString()));
                    double totalgst = gst * Convert.ToDouble(this.txttotal.Text.ToString());
                    double total = totalgst + Convert.ToDouble(this.txttotal.Text.ToString());
                    txtgsttotal.Text = Convert.ToString(total);
                }
            }
        }

        private void txttotalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmwaranty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtgst.Focus();
            }
        }

        private void txtpwaranty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtgst.Focus();
            }
        }

        private void txtgst_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Select")
            { 
            }
            else if (comboBox1.SelectedItem.ToString() == "Mobile")
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txttotalamount.Focus();
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessaries")
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txttotalamount.Focus();
                }
            }
        }

        private void txtimei1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtimei2.Focus();
            }
        }

        private void txtimei2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                mmfgdate.Focus();
            }
        }

        private void mmfgdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmprice.Focus();
            }
        }

        private void txtmprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmodel.Focus();
            }
        }

        private void txtmodel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtcname.Focus();
            }
        }

        private void txtcname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtmwaranty.Focus();
            }
        }

        private void txttotal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txttotalamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Mobile")
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txtmsellprice.Focus();
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessaries")
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txtpsellprice.Focus();
                }
            }
        }

        private void txtmsellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtgsttotal.Focus();
            }
        }

        private void txtoid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            if (this.txtoid.Text.ToString().Length == 0)
            {
                lblsname.Hide();
            }
            else if (this.txtoid.Text.ToString().Length != 0)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select Supplier_Name from Supplier,OrderHeader where Supplier.Supplier_Id=OrderHeader.Supplier_Id and Order_Id='" + this.txtoid.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblsname.Text = dr["Supplier_Name"].ToString();
                    comboBox1.SelectedIndex = 1;
                    lblsname.Show();
                }
                else
                {
                    MessageBox.Show("Order Id is Wrong");
                    lblsname.Hide();
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void btnclere_Click(object sender, EventArgs e)
        {
            btnaddstock.Enabled = true;
            txtimei1.Clear();
            txtimei2.Clear();
            txtmodel.Clear();
            txtcname.Clear();
            mmfgdate.ResetText();
            txtmwaranty.Clear();
            txtmprice.Clear();
            txtmsellprice.Clear();
            txtpname.Clear();
            txtpmodel.Clear();
            pmfgdate.ResetText();
            txtpwaranty.Clear();
            txtqty.Clear();
            txtpprice.Clear();
            txttotal.Clear();
            txtpsellprice.Clear();
            txtgst.Clear();
            txtgsttotal.Clear();
            txttotalamount.Clear();
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}