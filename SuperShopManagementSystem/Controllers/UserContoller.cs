using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopManagementSystem.Models;

namespace SuperShopManagementSystem.Controllers
{
    public class UserController
    {
        static Database db = new Database();
        public static void AddUser(string Id, string Username, string Name ,string UserType, string Password)
        {
            User u = new User();

            u.Id = Id;
            u.Username = Username;
            u.Name = Name;
            u.UserType = UserType;
            u.Password = Password;
          
            db.Users.AddUser(u);
        }
        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }

        //public string ArrayList GetAllUserTypes()
        //{
        //    return db.Users.GetAllUsers();
        //}

        public static void UpdateUser(string Id, string Username, string Name, string UserType, string Password)
        {
            User u = new User();

            u.Id = Id;
            u.Username = Username;
            u.Name = Name;
            u.UserType = UserType;
            u.Password = Password;

            db.Users.AddUser(u);
        }
    }
}
