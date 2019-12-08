using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopManagementSystem.Models;
using SuperShopManagementSystem.Controllers;

namespace SuperShopManagementSystem.Views
{
    public partial class AddUserViews : Form
    {
        public AddUserViews()
        {
            InitializeComponent();

            //????????????????

            comboBoxUserType.DataSource = textBoxUserType;
            comboBoxUserType.DisplayMember = "UserType";
            comboBoxUserType.DisplayMember = "Id";
            //dataGridViewAddUsers.DataSource = user;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            new ManazerDashboardView().Show();   // go to home 
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // add Parson
            var ut = comboBoxUserType.SelectedItem;
            UserController.AddUser(  textBoxId.Text,   textBoxUsername.Text,textBoxName.Text,textBoxUserType.Text,textBoxPassword.Text);
            //dataGridViewAllUser.DataSource = UserController.GetAllUser();
        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllUser_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void RowChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void Pro(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
