using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeeManufacture.WebUI.Startup))]
namespace BeeManufacture.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
