using System;
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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
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
            new ManazerDashboardView().Show();
        }
    }
}
