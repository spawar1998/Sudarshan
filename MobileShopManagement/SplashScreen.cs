﻿using System;
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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelslide.Width += 1;
            if (panelslide.Width > 300)
            {
                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void panelslide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
