using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    public partial class CPayment : Form
    {
        string NO, Paymode,shopno;
        public CPayment(string no,string mode)
        {
            InitializeComponent();
            NO = no;
            Paymode = mode;
        }


        private void btnpay_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con2.Open();
            string q2 = "Select c_pay_tras_no from CustomerPayment where billno='" + this.NO.ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(q2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString() !="")
                {
                    MessageBox.Show("Payment alread paid");
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                string q = "Select Shop_No from MobileShop";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    shopno = dr["Shop_No"].ToString();

                    SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con1.Open();
                    string q1 = "insert into CustomerPayment(c_pay_tras_no,c_pay_mode,c_pay_date,bill_amount,Cust_id,Cust_Name,Cust_Contact,billno,Shop_number)" +
                        "Values('" + this.lbltrasno.Text.ToString() + "','" + this.lblpaymode.Text.ToString() + "','" + this.PayDate.Value.ToShortDateString() + "','" + this.lblamount.Text.ToString() + "' , '" + this.lblcustid.Text.ToString() + "' , '" + this.lblcname.Text.ToString() + "' , '" + this.lblcontact.Text.ToString() + "' , '" + this.NO.ToString() + "' , '" + this.shopno.ToString() + "')";
                    SqlCommand cmd1 = new SqlCommand(q1, con1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    MessageBox.Show("Bill Paid Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    con1.Close();
                }
                con.Close();
            }
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            PayDate.CustomFormat = "dd/MM/yyyy";
            PayDate.MaxDate = DateTime.Today;
            PayDate.Value = DateTime.Today;
            PayDate.Value.Date.ToShortDateString();
            int a;
            
            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con1.Open();
            string q1 = "Select Customer.Customer_Id,Customer_Name,c_bill_finalamt,Customer_Contact from Customer,Cbillheader where Cbillheader.customer_id=Customer.Customer_Id and c_bill_no='" + this.NO.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                lblcustid.Text = dr1["Customer_Id"].ToString();
                lblcname.Text = dr1["Customer_Name"].ToString();
                lblamount.Text = dr1["c_bill_finalamt"].ToString();
                lblcontact.Text = dr1["Customer_Contact"].ToString();
            }
            con1.Close();

            lblbillno.Text = NO.ToString();
            lblpaymode.Text = Paymode.ToString();

            SqlConnection con2 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con2.Open();
            string q2 = "Select c_pay_tras_no from CustomerPayment where billno='" + this.NO.ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(q2, con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                if (dr2[0].ToString() == "")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                    con.Open();
                    string q = "Select max(c_pay_tras_no) from CustomerPayment";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == "")
                        {
                            lbltrasno.Text = "100";
                        }
                        else
                        {
                            a = Convert.ToInt16(dr[0].ToString());
                            lbltrasno.Text = (a + 1).ToString();
                        }
                    }
                    con.Close();
                }
                else
                {
                    lbltrasno.Text = dr2[0].ToString();
                }
            }
            else
            {
                SqlConnection con3 = new SqlConnection(Properties.Settings.Default.sqlcon);
                con3.Open();
                string q3 = "Select max(c_pay_tras_no) from CustomerPayment";
                SqlCommand cmd3 = new SqlCommand(q3, con3);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    if (dr3[0].ToString() == "")
                    {
                        lbltrasno.Text = "100";
                    }
                    else
                    {
                        a = Convert.ToInt16(dr3[0].ToString());
                        lbltrasno.Text = (a + 1).ToString();
                    }
                }
                con3.Close();
            }
            con2.Close();
        }
    }
}
