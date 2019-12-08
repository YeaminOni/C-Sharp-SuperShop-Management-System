using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SuperShopManagementSystem.Models
{
    public class Products
    {
        SqlConnection conn;
        public Products()
        {
            conn = new SqlConnection("Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");

        }

        public void AddProduct(Product product)//   adding product
        {
            conn.Open();
            string query = "INSERT INTO Products (ProductId,ProductName,ProductPrice,ProductQuantity,Category) VALUES('" + product.ProductId + "','" + product.ProductName + "','" + product.ProductPrice + "','"+product.ProductQuantity+"', '"+ product.Category + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }

        //-------------------------------------------------------
        public Product GetProduct(string productName)// get product
        {
            Product p = new Product();
            return p;
        }
        //----------------------------------
        public ArrayList GetAllProduct()// get all products
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product();
                
                p.ProductId = reader.GetString(reader.GetOrdinal("ProductId"));
                p.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                p.ProductPrice = reader.GetString(reader.GetOrdinal("ProductPrice"));
                p.ProductQuantity = reader.GetString(reader.GetOrdinal("ProductQuantity"));
                p.Category = reader.GetString(reader.GetOrdinal("Category"));


                products.Add(p);

            }
            conn.Close();
            return products;
        }





        
    }
}
