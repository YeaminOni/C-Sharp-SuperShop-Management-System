using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SuperShopManagementSystem.Controllers;

namespace SuperShopManagementSystem.Models
{
    public class UserTypes
    {
        SqlConnection conn;
        public UserTypes()
        {
            conn = new SqlConnection("Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");
        }
   
        public ArrayList GetAllUserTypes()
        {
            ArrayList UserType = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM UserType";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserType temp = new UserType();
                temp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                temp.TypeName = reader.GetString(reader.GetOrdinal("UserType"));
                UserType.Add(temp);


            }
            conn.Close();
            return UserType;
        }
    }
}
