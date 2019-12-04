//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;


//namespace SuperShopManagementSystem.Models
//{
//    public class Products
//    {
//        SqlConnection conn;
//        public Products()
//        {
//            conn = new SqlConnection("Server=DESKTOP-R30TBUF;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");

//        }

//        public void AddProduct(Product product)
//        {
//            conn.Open();
//            string query = "INSERT INTO Products (ProductName,ProductPrice,ProductQty,CategoryId) VALUES('" + product.ProductName + "'," + product.ProductPrice + "," + product.ProductQty + "," + product.CategoryId + ")";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            int result = cmd.ExecuteNonQuery();
//            conn.Close();
//        }
//    }
//}
