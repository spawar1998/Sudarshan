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
    public partial class MasterScreen : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MasterScreen()
        {
            InitializeComponent();
            player.SoundLocation = "Alan_Walker_-_Fade_[NCS_Release](256k).wav";
            player.SoundLocation = "Alan_Walker_-_Fade_[NCS_Release](256k).wav";
        }

        private void MasterScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Registration re = new Registration();
            this.Close();
            re.Show();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
            player.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            this.Close();
            p.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //player.Play();
        }

        private void startmusic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            player.PlayLooping();
            startmusic.Hide();
            stopmusic.Show();
        }

        private void stopmusic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            player.Stop();
            stopmusic.Hide();
            startmusic.Show();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
        }

        private void btnsupplier_Click_1(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            Sell s = new Sell();
            s.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            ReportMenu rm = new ReportMenu();
            rm.Show();
        }

        private void btnemployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnsupplier.Focus();
            }
        }

        private void btnsupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnpurchase.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            SupplierPayment sp = new SupplierPayment();
            sp.Show();
        }
    }
}
