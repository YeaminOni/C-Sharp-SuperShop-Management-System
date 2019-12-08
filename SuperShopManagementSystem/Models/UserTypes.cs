using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperShopManagementSystem.Models
{
    public class UserTypes
    {
        SqlConnection conn;
        public UserTypes()
        {
            conn = new SqlConnection("Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");
        }
        public void AddUserType(Category c)
        {
        }
        public void DeleteUserType(Category c)
        {
        }
        public void UpdateUserTypes(Category c)
        {
        }
        public Category GetUserTypes(string CategoryName)
        {
            Category c = new Category();
            return c;
        }
        public ArrayList GetAllUserType()
        {
            ArrayList categories = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM UserType";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserType temp = new UserType();
                temp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                temp.Category = reader.GetString(reader.GetOrdinal("Category"));
                categories.Add(temp);


            }
            conn.Close();
            return categories;
        }
    }
}
