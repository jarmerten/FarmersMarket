using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Farmers_Market.Startup))]
namespace Farmers_Market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
