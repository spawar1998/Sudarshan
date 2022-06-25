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
    public partial class SupplierPayment : Form
    {
        public SupplierPayment()
        {
            InitializeComponent();
        }

        private void SupplierPayment_Load(object sender, EventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {
            SPayment sp = new SPayment("Bank Transfer");
            sp.Show();
            this.Hide();
        }

        private void lblcash_Click(object sender, EventArgs e)
        {
            SPayment sp = new SPayment("Cash");
            sp.Show();
            this.Hide();
        }
    }
}
