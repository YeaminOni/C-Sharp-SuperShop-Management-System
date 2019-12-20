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
using System.Data.SqlClient;
using SuperShopManagementSystem.Views;

namespace SuperShopManagementSystem
{
    public partial class CustomerDashbordViews : Form
    {
        SqlConnection con = new SqlConnection(@"Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");
        DataTable dt = new DataTable();
        public CustomerDashbordViews()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  new start().Show();
            // Visible = false;
            //this.Close();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
  //page lode event
        private void Customer_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {

        }

        private void buttonPurchaseInfo_Click(object sender, EventArgs e)
        {
           // new start().Show();
            // Visible = false;
            //this.Close();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            //new Start().Show();
            // Visible = false;
            //this.Close();
            //this.Hide();
        }
        //          SEARCHING PRODUCT...................FROM CUSTOMER.............
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxSearch.Visible = true;
            listBoxSearch.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where ProductName like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                listBoxSearch.Items.Add(" Product Name= " + dr["ProductName"].ToString() + "  ,   Product Quantity= " + dr["ProductQuantity"].ToString()+ "    , Product Id= " + dr["ProductId"].ToString());
               
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxSearch.Focus();
                listBoxSearch.SelectedIndex = 0;

            }
        }

        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new Start().Show();


            //this.Close();
            this.Hide();
        }
    }
}
