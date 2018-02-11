using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DatePurchased { get; set; }

        public Double TotalPrice{get ;set; }

        public Status Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual User User { get; set; }
        

    }
    public enum Status { wating, packing, shipping }
    
}