using GroceryStoreApp.ViewModels;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


namespace GroceryStoreApp.Controllers
{
    [Authorize]

    public class AccountController : Controller
    {
        private SignInManager _signInManager;
        private UserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(UserManager userManager, SignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public SignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<SignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public UserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<UserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        //GET: Account/Login
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        //POST ; 
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);


        }
    }
}