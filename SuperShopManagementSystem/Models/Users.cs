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
      
        public User AuthenticateUser(string username, string password)//have a problem...
        {
            User u=null;
            conn.Open();
          //  User u = null;
            string query = "SELECT * FROM Usears WHERE UserName='" + username + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u = new User();
                //u.Name = reader.GetString(reader.GetOrdinal("Name"));
                u.Username = reader.GetString(reader.GetOrdinal("Username"));
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
            string query = "INSERT INTO Usears (Id,Username,Name,Catagory,Password) VALUES ('" + user.Id + "', '"+ user.Username +"','"+ user.Name + "', '" + user.Category + "','"+ user.Password+"')";
           SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();


        }


        public void DeleteUser(User user)
        {
         //delete user from database

        }
        //public void UpdateUser(User user)
        //{
        //    //update user into database
        //}


        public User GetUser(User user)

        {
            //delete user from database

            User u = new User();
            return u;

        }

        //public ArrayList GetAllUser()
        //{
        //    ArrayList Uaers = new ArrayList();

        //    User user = new User();
        //    conn.Open();
        //    string query = "SELECT * FROM Users";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {

        //        User u = new User()
        //        {
        //            Id = reader.GetString(reader.GetOrdinal("Id")),
        //            Username = reader.GetString(reader.GetOrdinal("Username")),
        //            Name = reader.GetString(reader.GetOrdinal("Name")),
        //            Category = reader.GetString(reader.GetOrdinal("Category")),
        //            Password = reader.GetString(reader.GetOrdinal("Password")),




        //        };
        //       // Users.AddUser(u);



        //    }
        //    conn.Close();
        //    //return User;


        //}



    }
}
