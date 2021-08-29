using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Mahedee.net.Startup))]
namespace Web.Mahedee.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
