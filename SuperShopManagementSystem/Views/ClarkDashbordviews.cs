﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystem.Views
{
    public partial class ClarkDashbordviews : Form
    {
        public ClarkDashbordviews()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            new Start().Show();

          
            //this.Close();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClarkDashbordviews_Load(object sender, EventArgs e)
        {

        }

        private void buttonSellProducts_Click(object sender, EventArgs e)
        {
            new Sales().Show();
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //new ClarkDashbordviews().Show();
            
            // Visible = false;
            //this.Close();
            //this.Hide();
        }
    }
}
