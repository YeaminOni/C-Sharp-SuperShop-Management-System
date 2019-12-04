using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperShopManagementSystem.Models
{


    public class Users
    {
        SqlConnection conn;
        public Users()
        {
            conn = new SqlConnection("Server=NUR;Database=login;User Id=sa;Password=80659;");

        }
        //public void AddUser(User user)
        //{
        //    //add user to the database
        //    conn.Open();
        //    string query = "INSERT INTO Users (Name,Password) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "')";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    int result = cmd.ExecuteNonQuery();
        //    conn.Close();


        //}
        public User AuthenticateUser(string username, string password)//have a problem...
        {
            User u=null;
            conn.Open();
          //  User u = null;
            string query = "SELECT * FROM login1 WHERE Username='" + username + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new User();
                //u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                //u.Password = reader.GetString(reader.GetOrdinal("Password"));
                //u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            }
            conn.Close();

            return u;

        }
        //public void DeleteUser(User user)
        //{
        //    //delete user from database

        //}
        //public void UpdateUser(User user)
        //{
        //    //update user into database
        //}
        //public User GetUser(string username)
        //{
            
        //    User user = new User();
        //    return user;
        //}


    }
}
