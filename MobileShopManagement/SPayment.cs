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

namespace MobileShopManagement
{
    public partial class SPayment : Form
    {
        string paystatus;
        string paymode;
        public SPayment(string pmode)
        {
            InitializeComponent();
            paymode = pmode;
            lblpaymode.Text = paymode;
        }

        private void SPayment_Load(object sender, EventArgs e)
        {
            lblpaymode.Hide();
            label10.Hide();
            lbltransno.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label8.Hide();
            label18.Hide();
            label7.Hide();
            label9.Hide();
            lblbillamt.Hide();
            lblbalanceamt.Hide();
            lblsid.Hide();
            lblpaid.Hide();
            lblpending.Hide();
            lblsname.Hide();
            txtamt.Hide();
            btnpay.Hide();

            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Value.Date.ToShortDateString();

            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtoid.Text.ToString().Length != 0)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select Order_Date,Total_amt,Supplier.Supplier_Id,Supplier_Name,Supplier_Contact from OrderHeader,Supplier where OrderHeader.Supplier_Id=Supplier.Supplier_Id and Order_Id='" + this.txtoid.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //dateTimePicker1.Value = Convert.ToDateTime(dr["Order_Date"].ToString());
                    lblbillamt.Text = dr["Total_amt"].ToString();
                    lblsid.Text = dr["Supplier_Id"].ToString();
                    lblsname.Text = dr["Supplier_Name"].ToString();

                    lblpaymode.Show();
                    label10.Show();
                    lbltransno.Show();
                    label3.Show();
                    label4.Show();
                    label6.Show();
                    label8.Show();
                    label18.Show();
                    label7.Show();
                    label9.Show();
                    lblbillamt.Show();
                    lblbalanceamt.Show();
                    lblsid.Show();
                    lblpaid.Hide();
                    lblpending.Show();
                    lblsname.Show();
                    txtamt.Show();
                    btnpay.Show();

                    int a;

                    SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con2.Open();
                    string q2 = "Select s_pay_tras_no,balance_amt from SupplierPayment where order_id='" + this.txtoid.Text.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(q2, con2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        if (dr2[0].ToString() == "")
                        {
                            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                            con1.Open();
                            string q1 = "Select max(s_pay_tras_no),s_pay_mode,s_pay_date,s_bill_amount,s_paid_amount,balance_amt,s_pay_status from SupplierPayment";
                            SqlCommand cmd1 = new SqlCommand(q1, con1);
                            SqlDataReader dr1 = cmd1.ExecuteReader();
                            if (dr1.Read())
                            {
                                if (dr1[0].ToString() == "")
                                {
                                    lbltransno.Text = "100";
                                }
                                else
                                {
                                    a = Convert.ToInt16(dr1[0].ToString());
                                    lbltransno.Text = (a + 1).ToString();
                                }
                            }
                            con.Close();
                        }
                        else
                        {
                            lbltransno.Text = dr2[0].ToString();
                            lblbillamt.Text = dr2["balance_amt"].ToString();
                            if (lblbillamt.Text.ToString() == "0")
                            {
                                MessageBox.Show("Payment Already Done !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con3.Open();
                        string q3 = "Select max(s_pay_tras_no) from SupplierPayment";
                        SqlCommand cmd3 = new SqlCommand(q3, con3);
                        SqlDataReader dr3 = cmd3.ExecuteReader();
                        if (dr3.Read())
                        {
                            if (dr3[0].ToString() == "")
                            {
                                lbltransno.Text = "100";
                            }
                            else
                            {
                                a = Convert.ToInt16(dr3[0].ToString());
                                lbltransno.Text = (a + 1).ToString();
                            }
                        }
                        con3.Close();
                    }
                    con2.Close();

                }
                else
                {
                    MessageBox.Show("Record Not Found", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Order ID","",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                label4.Hide();
                label6.Hide();
                label8.Hide();
                label18.Hide();
                label7.Hide();
                label9.Hide();
                lblbillamt.Hide();
                lblbalanceamt.Hide();
                lblsid.Hide();
                lblpaid.Hide();
                lblpending.Hide();
                lblsname.Hide();
                txtamt.Hide();
                btnpay.Hide();
            }
        }

        private void txtamt_TextChanged(object sender, EventArgs e)
        {
            if (txtamt.Text.ToString().Length == 0)
            {
                lblbalanceamt.Text = "0";
            }
            else if (txtamt.Text.ToString().Length != 0)
            {
                if (Convert.ToDouble(lblbillamt.Text.ToString()) >= Convert.ToDouble(txtamt.Text.ToString()))
                {
                    lblbalanceamt.Text = Convert.ToString((Convert.ToDouble(lblbillamt.Text.ToString())) - Convert.ToDouble(txtamt.Text.ToString()));
                }
                else
                {
                    MessageBox.Show("Invalid Amount","",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                }
            }
            if (txtamt.Text.ToString().Length == 0)
            {
                lblbalanceamt.Text = "0";
            }
            else if (Convert.ToDouble(lblbillamt.Text.ToString()) == Convert.ToDouble(txtamt.Text.ToString()))
            {
                lblpaid.Show();
                lblpending.Hide();
            }
            else
            {
                lblpending.Show();
                lblpaid.Hide();
            }
        }

        private void txtoid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (txtamt.Text.ToString().Length != 0)
            {
                if (Convert.ToDouble(lblbillamt.Text.ToString()) == Convert.ToDouble(txtamt.Text.ToString()))
                {
                    paystatus = "Paid";
                }
                else
                {
                    paystatus = "Pending";
                }

                SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
                con2.Open();
                string q2 = "Select s_pay_tras_no,s_bill_amount,s_paid_amount,balance_amt,s_pay_status from SupplierPayment where order_id='" + this.txtoid.Text.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    if (dr2["s_bill_amount"].ToString() == dr2["s_paid_amount"].ToString() && dr2["balance_amt"].ToString() == "0" && dr2["s_pay_status"].ToString() == "Paid")
                    {
                        MessageBox.Show("Payment alread paid");
                    }
                    else
                    {
                        SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                        con3.Open();
                        string q3 = "update SupplierPayment set s_pay_mode='" + this.lblpaymode.Text.ToString() + "',s_pay_date='" + this.dateTimePicker1.Value.ToShortDateString() + "',s_paid_amount=s_paid_amount +'" + this.txtamt.Text.ToString() + "'," +
                                                     "balance_amt= '" + this.lblbalanceamt.Text.ToString() + "', s_pay_status= '" + this.paystatus.ToString() + "'where s_pay_tras_no ='" + this.lbltransno.Text.ToString() + "' and order_id='" + this.txtoid.Text.ToString() + "'";
             
                        
                        SqlCommand cmd3 = new SqlCommand(q3, con3);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Bill Paid Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        con3.Close();
                    }
                }
                else
                {
                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con1.Open();
                    string q1 = "insert into SupplierPayment(s_pay_tras_no,s_pay_mode,s_pay_date,s_bill_amount,s_paid_amount,balance_amt,s_pay_status,Supp_id,supplier_name,order_id)" +
                        "Values('" + this.lbltransno.Text.ToString() + "','" + this.lblpaymode.Text.ToString() + "','" + this.dateTimePicker1.Value.ToShortDateString() + "','" + this.lblbillamt.Text.ToString() + "' , '" + this.txtamt.Text.ToString() + "' , '" + this.lblbalanceamt.Text.ToString() + "' , '" + this.paystatus.ToString() + "' , '" + this.lblsid.Text.ToString() + "' , '" + this.lblsname.Text.ToString() + "' , '" + this.txtoid.Text.ToString() + "')";
                    SqlCommand cmd1 = new SqlCommand(q1, con1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    MessageBox.Show("Bill Paid Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    con1.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Amount", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
