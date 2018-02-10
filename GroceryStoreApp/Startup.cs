using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroceryStoreApp.Startup))]
namespace GroceryStoreApp
{
    
        public partial class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                ConfigureAuth(app);
            }
        }
    

}