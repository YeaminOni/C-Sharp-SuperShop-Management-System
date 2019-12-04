//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SuperShopManagementSystem.Models;

//namespace SuperShopManagementSystem.Controllers
//{
//    public class ProductController
//    {
//         static Database db = new Database();
//        public static void AddProduct(string pName,string pPrice,string pQty, int catId)
//        {
//            Product p = new Product()
//            {
//                ProductName = pName,
//                ProductPrice = Int32.Parse(pPrice),
//                ProductQty = Int32.Parse(pQty),
//                CategoryId = catId

//            };
//            db.Products.AddProduct(p)
//    }
//}
