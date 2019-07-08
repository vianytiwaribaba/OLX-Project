using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLX.Web.Startup))]
namespace OLX.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
