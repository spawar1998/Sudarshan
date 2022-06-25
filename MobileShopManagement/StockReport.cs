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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DataSet1 ds = new DataSet1();
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from StockMobile";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.DataTable1);
                StockMobileReports myreport = new StockMobileReports();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                con.Close();
            }
            else if (radioButton2.Checked == true)
            {
                StockAccessariesDataSet1 ds = new StockAccessariesDataSet1();
                SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from StockAccessaries";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.DataTable1);
                StockAccessariesReport myreport = new StockAccessariesReport();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select Stock Type","",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
        }
    }
}
