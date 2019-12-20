using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SuperShopManagementSystem.Views
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        

        private void buttonManazer_Click(object sender, EventArgs e)
        {
            
            new LoginView().Show();
            // Visible = false;
            //this.Close();
            this.Hide();

        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            new CustomerDashbordViews().Show();
           
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void buttonClark_Click(object sender, EventArgs e)
        {
           new ClarkDashbordviews().Show();
          //  new Start().Show();


            //this.Close();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
