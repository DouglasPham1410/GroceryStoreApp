using GroceryStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.DAL
{
    public class StoreDBInitializer : DropCreateDatabaseAlways<StoreDbContent>
    {
      
        protected override void Seed(StoreDbContent context)
        {
            IList<Category> categories = new List<Category>();
            categories.Add(new Category() { Name = "Dairy" });
            categories.Add(new Category() { Name = "Meats" });
            categories.Add(new Category() { Name = "Bakery" });
            categories.Add(new Category() { Name = "Fuit & Veg" });

            foreach(Category c in categories)
            {
                context.Category.Add(c);
            }
            StoreDbContent db = new StoreDbContent();

            IList<Product> products = new List<Product>();

           // var p = new Product() { Name = "Milk", Description = "Mellan mjölk från Arla", Price = 19.5, Quantity = 20, Category =  db.Cartegory.SingleOrDefault( e => e.Id==1) , };

            //context.Product.Add(p);
            base.Seed(context);
        }
    }
}