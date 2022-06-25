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
    public partial class CustomerPaymentReport : Form
    {
        public CustomerPaymentReport()
        {
            InitializeComponent();
        }

        private void CustomerPaymentReport_Load(object sender, EventArgs e)
        {
            mindate.CustomFormat = "dd/MM/yyyy";
            mindate.MaxDate = DateTime.Today;
            mindate.Value = DateTime.Today;
            mindate.Value.Date.ToShortDateString();

            maxdate.CustomFormat = "dd/MM/yyyy";
            maxdate.MaxDate = DateTime.Today;
            maxdate.Value = DateTime.Today;
            maxdate.Value.Date.ToShortDateString();

            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Customer_Name from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Customer_Name"].ToString());
            }
            con.Close();

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            CustomerPaymentDataSet ds = new CustomerPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select c_pay_tras_no,billno,Cust_id,Cust_Name,bill_amount,c_pay_date,c_pay_mode from CustomerPayment";
            cmd.ExecuteNonQuery();
            if (cmd.ToString() != "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.DataTable1);
                CustomerPaymentCrystalReport cpcr = new CustomerPaymentCrystalReport();
                cpcr.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cpcr;
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            CustomerPaymentDataSet cpds = new CustomerPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select c_pay_tras_no,billno,Cust_id,Cust_Name,bill_amount,c_pay_date,c_pay_mode from CustomerPayment where c_pay_date between '" + this.mindate.Value.ToShortDateString() + "' and '" + this.maxdate.Value.ToShortDateString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(cpds.DataTable1);
            CustomerPaymentCrystalReport cdr = new CustomerPaymentCrystalReport();
            cdr.SetDataSource(cpds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();

        }
        private void btncustomerbill_Click(object sender, EventArgs e)
        {
            CustomerPaymentDataSet ds = new CustomerPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select c_pay_tras_no,billno,Cust_id,Cust_Name,bill_amount,c_pay_date,c_pay_mode from CustomerPayment where Cust_Name='" + this.comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            CustomerPaymentCrystalReport cdr = new CustomerPaymentCrystalReport();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }
    }
}
