using System;
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
        public static void AddUser(string Id, string Username, string Name ,string Category, string Password)
        {
            User u = new User();

            u.Id = Id;
            u.Username = Username;
            u.Name = Name;
            u.Category = Category;
            u.Password = Password;
          
            db.Users.AddUser(u);
        }

        //public string ArrayList GetAllUser()
        //{
        //    return db.Users.GetAllUser();
        //}

    }
}
