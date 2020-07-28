using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityInMVC.Startup))]
namespace IdentityInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
