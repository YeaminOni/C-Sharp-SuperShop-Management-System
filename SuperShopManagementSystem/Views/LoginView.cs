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

            //   for user type...............................
            comboBoxType.DataSource = UserTypesControler.GetAllUserTypes();

            // comboBoxUserType.DisplayMember = "UserName";
            comboBoxType.ValueMember = "TypeName";
            comboBoxType.ValueMember = "Id";
           
        }

        private void LoginClick(object sender, EventArgs e)
        {

            var result = LoginController.AuthenticateUser(textBoxUname.Text, comboBoxType.Text, textBoxPassword.Text );
            if (result == true)
            {
                //string cbItem = comboBoxType.SelectedItem.ToString();
                // int a= comboBoxType.SelectedIndex;

                //...................good night......
                if (comboBoxType.SelectedIndex == 1)
                {
                    new ClarkDashbordviews().Show();

                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    new CustomerDashbordViews().Show();
                }
                else if (comboBoxType.SelectedIndex == 0)
                {
                    new ManazerDashboardView().Show();
                }
                else
                {
                    MessageBox.Show("Failure", "Alert");
                }

                    
                
            }
            else
            {
                MessageBox.Show("Failure", "Alert");
                new LoginView().Show();

            }
        
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new Start().Show();


            //this.Close();
            this.Hide();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            new Start().Show();


            //this.Close();
            this.Hide();
        }
    }
}
