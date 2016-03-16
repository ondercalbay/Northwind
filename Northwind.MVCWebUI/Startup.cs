using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwind.MVCWebUI.Startup))]
namespace Northwind.MVCWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
