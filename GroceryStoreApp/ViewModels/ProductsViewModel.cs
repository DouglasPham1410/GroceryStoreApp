using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryStoreApp.ViewModels
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public string Decriptiopn { get; set; }

    }
   public class CateroryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    
    public class CategoryProductsViewModel
    {

    }
}