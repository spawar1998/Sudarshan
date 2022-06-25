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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            CustomerReportDataSet1 ds = new CustomerReportDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            CustomerDetailReport cdr = new CustomerDetailReport();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }
    }
}
