using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagement
{
    public partial class SupplierPaymentReport : Form
    {
        public SupplierPaymentReport()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            SupplierPaymentDataSet ds = new SupplierPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select s_pay_tras_no,order_id,Supp_id,supplier_name,s_bill_amount,s_pay_date,s_pay_mode from SupplierPayment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            SupplierPaymentCrystalReport cpcr = new SupplierPaymentCrystalReport();
            cpcr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cpcr;
            con.Close();
        }

        private void SupplierPaymentReport_Load(object sender, EventArgs e)
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
            cmd.CommandText = "Select Supplier_Name from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Supplier_Name"].ToString());
            }
            con.Close();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SupplierPaymentDataSet spds = new SupplierPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select s_pay_tras_no,order_id,Supp_id,supplier_name,s_bill_amount,s_pay_date,s_pay_mode from SupplierPayment where s_pay_date between '" + this.mindate.Value.ToShortDateString() + "' and '" + this.maxdate.Value.ToShortDateString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(spds.DataTable1);
            SupplierPaymentCrystalReport spcr = new SupplierPaymentCrystalReport();
            spcr.SetDataSource(spds);
            crystalReportViewer1.ReportSource = spcr;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncustomerbill_Click(object sender, EventArgs e)
        {
            SupplierPaymentDataSet spds = new SupplierPaymentDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select s_pay_tras_no,order_id,Supp_id,supplier_name,s_bill_amount,s_pay_date,s_pay_mode from SupplierPayment where supplier_name='" + this.comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(spds.DataTable1);
            SupplierPaymentCrystalReport spcr = new SupplierPaymentCrystalReport();
            spcr.SetDataSource(spds);
            crystalReportViewer1.ReportSource = spcr;
            con.Close();
        }
    }
}
