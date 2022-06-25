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
    public partial class OrderReport : Form
    {
        public OrderReport()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            OrderReportDataSet1 ds = new OrderReportDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select OrderDetails.Order_Id,Order_Date,Product_Type,Descreption,Product_Model,Quantity,Price,Total,Total_amt from OrderDetails,OrderHeader where Order_Date between '" + this.mindate.Value.ToShortDateString() + "' and '" + this.maxdate.Value.ToShortDateString() + "' and OrderDetails.Order_Id = OrderHeader.Order_Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            OrderCrystalReport1 cdr = new OrderCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }

        private void OrderReport_Load(object sender, EventArgs e)
        {
            mindate.CustomFormat = "dd/MM/yyyy";
            mindate.MaxDate = DateTime.Today;
            mindate.Value = DateTime.Today;
            mindate.Value.Date.ToShortDateString();

            maxdate.CustomFormat = "dd/MM/yyyy";
            maxdate.MaxDate = DateTime.Today;
            maxdate.Value = DateTime.Today;
            maxdate.Value.Date.ToShortDateString();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Select");
            SqlConnection con4 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con4.Open();
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "Select Supplier_Name from Supplier";
            cmd4.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            foreach (DataRow dr4 in dt.Rows)
            {
                comboBox1.Items.Add(dr4["Supplier_Name"].ToString());
            }
            con4.Close();

        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            OrderReportDataSet1 ds = new OrderReportDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select OrderDetails.Order_Id,Order_Date,Product_Type,Descreption,Product_Model,Quantity,Price,Total,Total_amt from OrderDetails,OrderHeader where OrderDetails.Order_Id = OrderHeader.Order_Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            OrderCrystalReport1 cdr = new OrderCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }

        private void btnsupplierorder_Click(object sender, EventArgs e)
        {
            OrderReportDataSet1 ds = new OrderReportDataSet1();
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select OrderDetails.Order_Id,Order_Date,Product_Type,Descreption,Product_Model,Quantity,Price,Total,Total_amt from OrderDetails,OrderHeader,Supplier where OrderDetails.Order_Id = OrderHeader.Order_Id and OrderHeader.Supplier_Id = Supplier.Supplier_Id and Supplier_Name='" + this.comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            OrderCrystalReport1 cdr = new OrderCrystalReport1();
            cdr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cdr;
            con.Close();
        }
    }
}
