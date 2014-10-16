using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTesting.Startup))]
namespace IdentityTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
