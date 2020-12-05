using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuth.Startup))]
namespace MVCAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
