using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperShopManagementSystem.Views
{
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection(@"Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");
        DataTable dt = new DataTable();
        int tot = 0;
        public Sales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");
        }

        private void textBoxPrroduct_KeyUp(object sender, KeyEventArgs e)
        {

            listBoxProduct.Visible = true;
            listBoxProduct.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where ProductId  like('" + textBoxPrroduct.Text + "%')";
            //cmd.CommandText = "select * from Products where ProductName like('" + textBoxPrroduct.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {

                listBoxProduct.Items.Add(dr["ProductName"].ToString());
            }
        }

        private void textBoxPrroduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrroduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void textBoxPrroduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                listBoxProduct.Focus();
                listBoxProduct.SelectedIndex = 0;

            }
        }

        private void listBoxProduct_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex + 1;


                }

                if (e.KeyCode == Keys.Up)
                {
                    this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex - 1;


                }

                if (e.KeyCode == Keys.Enter)
                {
                    textBoxPrroduct.Text = listBoxProduct.SelectedItem.ToString();
                    listBoxProduct.Visible = false;
                    textBoxPrice.Focus();


                }
                textBoxQuantity.Focus();

            }
            catch(Exception ex)
            {

            }

        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from Products where ProductName = '" + textBoxPrroduct.Text+ "' order by ProductId desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxPrice.Text = dr["ProductPrice"].ToString();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBoxTotal.Focus();


            }
        }
        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {

            try
            {
                textBoxTotal.Text = Convert.ToString(Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQuantity.Text));
            }
            catch (Exception ex)
            {

            }

        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                buttonAdd.Focus();


            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select* from Products where ProductName = '" + textBoxPrroduct.Text + "' ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                stock= Convert.ToInt32(dr1["ProductQuantity"].ToString());
            }
            if(Convert.ToInt32(textBoxQuantity.Text)>stock)
            {
                MessageBox.Show("This quantity is not availabl");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["Product"] = textBoxPrroduct.Text;
                dr["Price"] = textBoxPrice.Text;
                dr["Quantity"] = textBoxQuantity.Text;
                dr["Total"] = textBoxTotal.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                tot = tot + Convert.ToInt32(dr["Total"].ToString());

                labelTot.Text = tot.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString())); 
                foreach(DataRow dr1 in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr1["Total"].ToString());
                    labelTot.Text = tot.ToString();

                }
            }
            catch(Exception ex)
            {

            }
        }

        private void buttonSap_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into OrderUser values(' " +textBox1.Text + " ',' " + textBoxName.Text + " ',' " + comboBoxBillType.Text + " ',' " + dateTimePickerBillDate.Value.ToString("dd/mm/yyy") + " ' )";
            cmd1.ExecuteNonQuery();
            //DataTable dt1 = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd1);
            //da.Fill(dt1);


            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from OrderUser order by Id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)

            {
                orderid = dr2["Id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into OrderItem values(' " + orderid.ToString() + " ',' " + dr["Product"].ToString() + " ',' " + dr["Price"].ToString() + " ', ' " + dr["Quantity"].ToString() + " ',' " + dr["Total"].ToString() + " ')";
                 cmd3.ExecuteNonQuery();



                int quantity = 0;
                string productName;

                //quantity = Convert.ToInt32(dr[Quantity].ToString());
                //productName=dr


            }
            textBox1.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxPrroduct.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";

            labelTot.Text = "";
            dt.Clear();

            dataGridView1.DataSource = dt;
            MessageBox.Show("recod Inserted SuccesFully");

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            new ClarkDashbordviews().Show();
            // Visible = false;
            //this.Close();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 
