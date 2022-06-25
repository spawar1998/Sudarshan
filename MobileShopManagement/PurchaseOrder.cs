using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace MobileShopManagement
{
    public partial class PurchaseOrder : Form
    {
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        PrintDocument prntdoc = new PrintDocument();

        string poid,s_mail;
        public static string to;
        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpath.Text.ToString().Length != 0)
                {
                    string email = s_mail;
                    Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
                    Match match = regex.Match(email);
                    if (match.Success)
                    {
                        string sendmail = s_mail;
                        string from, pass, messageBody;
                        MailMessage message = new MailMessage();
                        to = s_mail;
                        from = "spprogrammer1998@gmail.com";
                        pass = "Sp1991998";
                        messageBody = "Purchase Order Details";
                        message.Attachments.Add(new Attachment(txtpath.Text));
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Order";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.Send(message);
                        MessageBox.Show("Otp Send Successfully On Your Register Mail", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (MessageBox.Show("Please Enter Valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Your Path", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                }
            }
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "(*.pdf)|(*.PDF)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                txtpath.Text = path;
            }
        }

        

        private void btnprint_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            //Graphics g = this.CreateGraphics();
             //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
             //Graphics mg = Graphics.FromImage(bmp);

            //             mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //           printPreviewDialog1.ShowDialog();   
            Print(panel1);
        }
        Bitmap bmp;

        private void label13_Click(object sender, EventArgs e)
        {

        }

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
            e.Graphics.DrawImage(bmp,(pagearea.Width/2)-(this.panel1.Width/2),this.panel1.Location.Y);
        }
        public void getprintarea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Purchase p = new Purchase();
            this.Close();
            //p.Show();
        }

   
        public PurchaseOrder(string pid)
        {
            InitializeComponent();
            poid = pid;
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Lime;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.0F, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            lblono.Text = poid;

            SqlConnection con1 = new SqlConnection(Properties.Settings.Default.sqlcon);
            con1.Open();
            string q = "select Order_Date,Total_amt,Supplier_Name,Supplier_Address,Supplier_Contact,Supplier_Mail from OrderHeader,Supplier where OrderHeader.Supplier_Id=Supplier.Supplier_Id and Order_Id='" + this.poid.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(q, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {

                DateTime date = Convert.ToDateTime(dr1["Order_Date"].ToString());
                lblodate.Text = date.ToShortDateString();
                lbltotalamt.Text = dr1["Total_amt"].ToString();
                lblsname.Text = dr1["Supplier_Name"].ToString();
                lblsaddress.Text = dr1["Supplier_Address"].ToString();
                lblcno.Text = dr1["Supplier_Contact"].ToString();
                lblsmail.Text = dr1["Supplier_Mail"].ToString();
                s_mail = dr1["Supplier_Mail"].ToString();
            }
            else 
            {
                MessageBox.Show("Order Not Placed");
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);
            con.Open();
            string query ="Select Product_Type,Descreption,Product_Model,Quantity,Price,Total from OrderDetails where Order_Id='"+this.poid.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
