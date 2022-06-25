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
    public partial class BillReport : Form
    {
        public BillReport()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BillDataSet1 ds = new BillDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Cbilldetails.c_bill_no,c_bill_date,Product_No,product_name,Model,mfg_date,waranty,quantity,rate,total,GST,GST_Price,Total_Amount_inc_Taxes,c_bill_totalamt from Cbilldetails,Cbillheader where c_bill_date between '" + this.mindate.Value.ToShortDateString() + "' and '" + this.maxdate.Value.ToShortDateString() + "' and Cbilldetails.c_bill_no=Cbillheader.c_bill_no";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            BillCrystalReport1 cdr = new BillCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            BillDataSet1 ds = new BillDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Cbilldetails.c_bill_no,c_bill_date,Product_No,product_name,Model,mfg_date,waranty,quantity,rate,total,GST,GST_Price,Total_Amount_inc_Taxes,c_bill_totalamt from Cbilldetails,Cbillheader where Cbilldetails.c_bill_no = Cbillheader.c_bill_no";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            BillCrystalReport1 cdr = new BillCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }

        private void BillReport_Load(object sender, EventArgs e)
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

        private void btncustomerbill_Click(object sender, EventArgs e)
        {
            BillDataSet1 ds = new BillDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Cbilldetails.c_bill_no,c_bill_date,Product_No,product_name,Model,mfg_date,waranty,quantity,rate,total,GST,GST_Price,Total_Amount_inc_Taxes,c_bill_totalamt from Cbilldetails,Cbillheader,Customer where Cbilldetails.c_bill_no = Cbillheader.c_bill_no and Cbillheader.customer_id = Customer.Customer_Id and Customer_Name='" + this.comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            BillCrystalReport1 cdr = new BillCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }
    }
}
