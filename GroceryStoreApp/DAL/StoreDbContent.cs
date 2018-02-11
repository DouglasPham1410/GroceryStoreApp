using GroceryStoreApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.DAL
{
    public class StoreDbContent : IdentityDbContext<User>
    {
        public StoreDbContent() : base("Name = GroceryStore")
        {
        }

        public static StoreDbContent Create()
        {
            return new StoreDbContent();
        }
        
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}