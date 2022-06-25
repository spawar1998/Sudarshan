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
    public partial class SupplierReport : Form
    {
        public SupplierReport()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void SupplierReport_Load(object sender, EventArgs e)
        {
            SupplierReportDataSet ds = new SupplierReportDataSet();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Supplier_Id,Supplier_Name,Supplier_Address,Supplier_Contact,Supplier_Mail,Company_Name from Supplier";
            cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            SupplierCrystalReport1 cdr = new SupplierCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }
    }
}
