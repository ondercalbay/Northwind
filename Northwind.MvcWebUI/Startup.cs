using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwind.MvcWebUI.Startup))]
namespace Northwind.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
