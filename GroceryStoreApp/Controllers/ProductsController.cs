using GroceryStoreApp.DAL;
using GroceryStoreApp.Models;
using GroceryStoreApp.ViewModels;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryStoreApp.Controllers
{
    public class ProductsController : Controller
    {
        private StoreDbContent _storeDbContent;

        public StoreDbContent StoreDbContent
        {
            get
            {
                return _storeDbContent ?? HttpContext.GetOwinContext().Get<StoreDbContent>();
            }
            private set
            {
                _storeDbContent = value;
            }
        }
       
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        // Get: Products/Categories
        public  ActionResult  Categories()
        {
            var categories = StoreDbContent.Category.OrderBy(c => c.Id).ToList();
            IList<CateroryViewModel> categoryViewModels = new List<CateroryViewModel>();
            foreach (Category c in categories)
            {
                categoryViewModels.Add(new CateroryViewModel { Id = c.Id, Name = c.Name });

            }
            return View(categoryViewModels);
        }
        public ActionResult ProductsByCategory(int Id)
        {
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            var result = StoreDbContent.Product.Where(p => p.CategoryId == Id).ToList();

            foreach(Product p in result)
            {
                productsViewModel.Add(new ProductViewModel {
                    Id = p.Id,
                    Name = p.Name,
                    Decriptiopn = p.Description,
                    Price = p.Price,
                    Quantity = p.Quantity
                
                });
            }
            return View(productsViewModel);
        }
        
    }
}