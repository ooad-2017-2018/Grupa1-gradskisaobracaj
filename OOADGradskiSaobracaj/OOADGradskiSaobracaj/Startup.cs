using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OOADGradskiSaobracaj.Startup))]
namespace OOADGradskiSaobracaj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
