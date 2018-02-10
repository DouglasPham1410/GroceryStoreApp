using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using GroceryStoreApp.Models;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using GroceryStoreApp.DAL;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;

namespace GroceryStoreApp
{

    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            //throw new System.NotImplementedException();
            return Task.FromResult(0);
        }
    }
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
    public class UserManager: UserManager<User>
    {
        public UserManager(IUserStore<User> store): base(store)
        {

        }
        public static UserManager Create(IdentityFactoryOptions<UserManager> options, IOwinContext context)
        {
            var manager = new UserManager(new UserStore<User>(context.Get<StoreDbContent>()));

            return manager;
        }
    }
    public class SignInManager: SignInManager<User,string>
    {
        public SignInManager(UserManager userManager, IAuthenticationManager authenticationManager):base(userManager,authenticationManager)
        {

        }
        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return user.GenerateUserIdentityAsync((UserManager)UserManager);
        }
        public static SignInManager Create(IdentityFactoryOptions<SignInManager> options, IOwinContext context)
        {
            return new SignInManager(context.GetUserManager<UserManager>(), context.Authentication);
        }
    }

}