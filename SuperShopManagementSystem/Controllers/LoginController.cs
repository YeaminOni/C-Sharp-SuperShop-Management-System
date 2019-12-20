using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopManagementSystem.Models;

namespace SuperShopManagementSystem.Controllers
{
    class LoginController
    {

        static Database db = new Database();
        static public bool AuthenticateUser(string username,string userType, string password)
        {
            bool result = false;

            var obj = db.Users.AuthenticateUser(username, userType, password);
            if (obj != null) result = true;
            return result;

        }
    }
}
