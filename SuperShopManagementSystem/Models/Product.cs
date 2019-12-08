using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopManagementSystem.Models;

namespace SuperShopManagementSystem.Models
{
   public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string Category{ get; set; }
    }
}
