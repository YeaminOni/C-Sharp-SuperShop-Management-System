using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopManagementSystem.Models
{
    class Database
    {

        public Users Users { get; set; }
        //public Products Products { get; set; }
        //public Categories Categories { get; set; }

        public Database()
        {
            Users = new Users();
           // Products = new Products();
            //Categories = new Categories();
        }
    }
}
