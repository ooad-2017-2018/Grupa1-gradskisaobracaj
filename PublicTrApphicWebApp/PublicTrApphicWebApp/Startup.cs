using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicTrApphicWebApp.Startup))]
namespace PublicTrApphicWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
