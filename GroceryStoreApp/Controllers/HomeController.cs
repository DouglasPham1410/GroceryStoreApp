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
    public class HomeController : Controller
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
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
      

        public ActionResult Contact()
        {

            return View();

        }


    }
}