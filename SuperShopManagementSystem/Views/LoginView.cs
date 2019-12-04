using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopManagementSystem.Controllers;

namespace SuperShopManagementSystem.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {

            var result = LoginController.AuthenticateUser(textBoxUname.Text, textBoxPassword.Text);
            if (result == true)
            {
                new ManazerDashboardView().Show();
            }
            else
            {
                MessageBox.Show("Failure", "Alert");
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
