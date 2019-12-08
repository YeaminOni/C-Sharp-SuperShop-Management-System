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
    public partial class ManazerDashboardView : Form
    {
        public ManazerDashboardView()
        {
            InitializeComponent();
        }

        private void ManazerDashboardView_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            new AddUserViews().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            var categories = CategoryController.GetAllCategories();
            var products = ProductController.GetAllProduct();
            new AddProductViews(categories, products).Show();


           
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            new Start().Show();
        }
    }
}
