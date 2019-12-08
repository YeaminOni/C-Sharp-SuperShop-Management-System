using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopManagementSystem.Models;

namespace SuperShopManagementSystem.Controllers
{
   public class CategoryController
    {
        static Database db = new Database();
        public static ArrayList GetAllCategories()
        {
            return db.Categories.GetAllCategories();
        }
    }
}
