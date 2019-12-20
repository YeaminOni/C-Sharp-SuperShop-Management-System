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
          
          


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            comboBoxUserType.DataSource = UserTypesControler.GetAllUserTypes();

            // comboBoxUserType.DisplayMember = "UserName";
            comboBoxUserType.ValueMember = "TypeName";
            // comboBoxUserType.DisplayMember = "UserType";
            dataGridViewAddUsers.DataSource = UserController.GetAllUsers();

        }

        private void buttonHome_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            new ManazerDashboardView().Show();   // go to home 
            
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // add Parson
            //var ut = comboBoxUserType.SelectedItem;
            UserController.AddUser(  textBoxId.Text,   textBoxUsername.Text,textBoxName.Text, comboBoxUserType.Text, textBoxPassword.Text);
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
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var c = dataGridViewAddUsers.SelectedRows[0].Cells[3].Value;
        }

        private void Pro(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void EditUser(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rw = dataGridViewAddUsers.CurrentRow;
            // MessageBox.Show(rw.Cells["Id"].Value.ToString());
            string Id = rw.Cells["Id"].Value.ToString();
            string Username = rw.Cells["Username"].Value.ToString();
            string UserType = rw.Cells["UserType"].Value.ToString();
            string Name = rw.Cells["Name"].Value.ToString();
            string Password = rw.Cells["PassWord"].Value.ToString();


            UserController.UpdateUser(Id,Username,Name,UserType, Password );
        }
    }
}
