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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        

        private void buttonManazer_Click(object sender, EventArgs e)
        {
            
            new LoginView().Show();

        }
    }
}
