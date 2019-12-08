using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopManagementSystem.Models;

namespace SuperShopManagementSystem.Controllers
{
    public class ProductController
    {
        static Database db = new Database();
        public static void AddProduct(string pId, string pName, string pPrice, string pQty, string catId)
        {
            Product p = new Product();


            p.ProductId =pId;
            p.ProductName = pName;
            p.ProductPrice =pPrice;
            p.ProductQuantity = pQty;
            p.Category = catId;








            db.Products.AddProduct(p);
        }

        public static ArrayList GetAllProduct()
        {
            return db.Products.GetAllProduct();
        }
    }
 }
