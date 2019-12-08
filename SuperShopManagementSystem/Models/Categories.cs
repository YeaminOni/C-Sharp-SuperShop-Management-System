using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SuperShopManagementSystem.Models
{
   public class Categories
    {
        SqlConnection conn;
        public Categories()
        {
            conn = new SqlConnection("Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");
        }
        public void AddCategory(Category c)
        {
        }
        public void DeleteCategory(Category c)
        {
        }
        public void UpdateCategory(Category c)
        {
        }
        public Category GetCategory(string CategoryName)
        {
            Category c = new Category();
            return c;
        }
        public ArrayList GetAllCategories()
        {
            ArrayList categories = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM ProductCatagories";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category temp = new Category();
                temp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                temp.CategoryName= reader.GetString(reader.GetOrdinal("Category"));
                categories.Add(temp);


            }
            conn.Close();
            return categories;
        }

    }
}
