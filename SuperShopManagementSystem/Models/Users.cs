using System;
using System.Collections;
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
            conn = new SqlConnection("Server=NUR;Database=SuperShopManagementSystem;User Id=sa;Password=80659;");

        }
      
        public User AuthenticateUser(string username,string userType, string password)//have a problem...
        {
            User u=null;
            conn.Open();
          //  User u = null;
            string query = "SELECT * FROM Usears WHERE UserName='" + username + "' AND  Password='" + password + "' AND UserType='" + userType + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new User();
                //u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
                u.UserType = reader.GetString(reader.GetOrdinal("UserType"));
                u.Password = reader.GetString(reader.GetOrdinal("Password"));
                //u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            }
            conn.Close();

            return u;

        }
       

        public void AddUser(User user)
        {
                        /*add user to the database*/
            conn.Open();
            string query = "INSERT INTO Usears (Id,Username,Name,UserType,Password) VALUES ('" + user.Id + "', '"+ user.Username +"','"+ user.Name + "', '" + user.UserType + "','"+ user.Password+"')";
           SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }


        public void DeleteUser(User user)
        {
         //delete user from database

        }
        public void UpdateUser(User user)
        {
            //update user into database
            conn.Open();
            string query = "UPDATE Users SET (Id,Username,Name,UserType,Password) VALUES ('" + user.Id + "', '" + user.Username + "','" + user.Name + "', '" + user.UserType + "','" + user.Password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            int rslt = cmd.ExecuteNonQuery();
            conn.Close();
        }


        public User GetUser(User user)

        {
            //delete user from database

            User u = new User();
            return u;

        }

        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Usears";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("UserName")),
                
                    UserType = reader.GetString(reader.GetOrdinal("UserType")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),


                };
                users.Add(u);
            }
            conn.Close();
            return users;
        }



    }
}
