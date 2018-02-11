using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public DateTime LateUpdate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual User User { get; set; }
    }
}