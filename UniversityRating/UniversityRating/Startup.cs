using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityRating.Startup))]
namespace UniversityRating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
