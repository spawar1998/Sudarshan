using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagement
{
    public partial class CustomerPayment : Form
    {
        string BillNo;

        public CustomerPayment(string billno)
        {
            InitializeComponent();
            BillNo = billno;
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {

        }

        private void visa_Click(object sender, EventArgs e)
        {
            CPayment p = new CPayment(this.BillNo,"Net Banking");
            p.Show();
        }

        private void mastercard_Click(object sender, EventArgs e)
        {
            CPayment p = new CPayment(this.BillNo, "Net Banking");
            p.Show();
        }

        private void discover_Click(object sender, EventArgs e)
        {
            CPayment p = new CPayment(this.BillNo, "Net Banking");
            p.Show();
        }

        private void americanexpress_Click(object sender, EventArgs e)
        {
            CPayment p = new CPayment(this.BillNo, "Net Banking");
            p.Show();
        }

        private void lblcash_Click(object sender, EventArgs e)
        {
            CPayment p = new CPayment(this.BillNo, "Cash");
            p.Show();
        }
    }
}
