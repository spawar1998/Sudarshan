using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace MobileShopManagement
{
    public partial class Bill : Form
    {
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        PrintDocument prntdoc = new PrintDocument();

        string billNO,totalamount;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdiscount.Text.ToString().Length == 0)
            { 
            }
            else if (Convert.ToDouble(lbltotalamt.Text.ToString()) >= Convert.ToDouble(this.txtdiscount.Text.ToString()))
            {
                if (txtdiscount.Text.ToString().Length == 0)
                {
                    lblfinalamount.Text = totalamount.ToString();
                }
                else
                {
                    lblfinalamount.Text = "";
                    lblfinalamount.Text = Convert.ToString(Convert.ToDouble(lbltotalamt.Text.ToString()) - (Convert.ToDouble(this.txtdiscount.Text)));
                }
            }
            else
            {
                MessageBox.Show("Discount is too high");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Digit allow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpaybill_Click(object sender, EventArgs e)
        {
            CustomerPayment cp = new CustomerPayment(this.lblbillno.Text.ToString());
            cp.Show();
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        { 
            dataGridView1.ClearSelection();
            Print(this.panel1);
        }

        
        Bitmap bmp;
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            ppd.Document = prntdoc;
            prntdoc.PrintPage += new PrintPageEventHandler(prntdoc_printpage);
            ppd.ShowDialog();
        }
        public void prntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        public void getprintarea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
       

        public Bill(string billno)
        {
            InitializeComponent();
            billNO = billno;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string query = "update Cbillheader set Discount='" + this.txtdiscount.Text.ToString() + "', c_bill_finalamt='" + this.lblfinalamount.Text.ToString() + "' where c_bill_no ='" + this.lblbillno.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully","",MessageBoxButtons.OKCancel);
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Lime;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.0F, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            lblbillno.Text = billNO.ToString();

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con1.Open();
            string q1 = "Select c_bill_date,c_bill_totalamt,Discount,c_bill_finalamt,Customer_Name,Customer_Address,Customer_Contact from Cbillheader,Customer where Cbillheader.customer_id=Customer.Customer_Id and c_bill_no='" + this.billNO.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                DateTime date;
                date = Convert.ToDateTime(dr1["c_bill_date"].ToString());
                lbldate.Text = date.ToShortDateString();
                lbltotalamt.Text = dr1["c_bill_totalamt"].ToString();
                lblcname.Text = dr1["Customer_Name"].ToString();
                lblcname1.Text = dr1["Customer_Name"].ToString();
                lblcaddress.Text = dr1["Customer_Address"].ToString();
                lblcontact.Text = dr1["Customer_Contact"].ToString();
                totalamount = dr1["c_bill_totalamt"].ToString();
                txtdiscount.Text = dr1["Discount"].ToString();
                lblfinalamount.Text = dr1["c_bill_finalamt"].ToString();
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string q = "Select Product_No,product_name,quantity,rate,total,GST,Total_Amount_inc_Taxes from Cbilldetails,Cbillheader where Cbillheader.c_bill_no = Cbilldetails.c_bill_no and Cbillheader.c_bill_no = '"+this.billNO+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
