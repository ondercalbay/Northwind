using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebUI.Startup))]
namespace MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
