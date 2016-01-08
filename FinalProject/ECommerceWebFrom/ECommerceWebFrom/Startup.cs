using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceWebFrom.Startup))]
namespace ECommerceWebFrom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
