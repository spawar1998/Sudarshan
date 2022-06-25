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
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmobilereport_Click(object sender, EventArgs e)
        {
            StockReport sm = new StockReport();
            sm.Show();
        }

        private void btnaccessariesreport_Click(object sender, EventArgs e)
        {

        }

        private void btncustomerreport_Click(object sender, EventArgs e)
        {
            CustomerReport cr = new CustomerReport();
            cr.Show();
        }

        private void btnorderreport_Click(object sender, EventArgs e)
        {
            OrderReport or = new OrderReport();
            or.Show();
        }

        private void btnbillreport_Click(object sender, EventArgs e)
        {
            BillReport br = new BillReport();
            br.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            SupplierReport sr = new SupplierReport();
            sr.Show();
        }

        private void btncpayment_Click(object sender, EventArgs e)
        {
            CustomerPaymentReport cpr = new CustomerPaymentReport();
            cpr.Show();
        }

        private void btnspayment_Click(object sender, EventArgs e)
        {
            SupplierPaymentReport spr = new SupplierPaymentReport();
            spr.Show();
        }
    }
}
