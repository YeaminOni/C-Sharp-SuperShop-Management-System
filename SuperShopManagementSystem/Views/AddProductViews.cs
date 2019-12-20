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
using SuperShopManagementSystem.Controllers;
using SuperShopManagementSystem.Models;
using SuperShopManagementSystem.Controllers;

namespace SuperShopManagementSystem.Views
{
    public partial class AddProductViews : Form
    {
        public AddProductViews(ArrayList categories, ArrayList products)
        {
            InitializeComponent();

            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "Id";
            dataGridViewAllProducts.DataSource = products;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            //`var c = (Category)comboBoxCategory.SelectedItem;
            ProductController.AddProduct(textBoxProductId.Text, textBoxProductName.Text, textBoxProductPrice.Text, textBoxProductQuantaty.Text, comboBoxCategory.Text);
            dataGridViewAllProducts.DataSource = ProductController.GetAllProduct();

        }

        private void pro(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridViewAllProducts.SelectedRows[0].Index.ToString();
            }
            catch (Exception ex)
            {
            }

        }


        private void RowChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            var c = dataGridViewAllProducts.SelectedRows[0].Cells[3].Value;

        }

        private void AddProductViews_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            new ManazerDashboardView().Show();
            
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPasseord_Click(object sender, EventArgs e)
        {

        }
    }
}
