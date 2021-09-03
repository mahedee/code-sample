using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRApp.Startup))]

namespace SignalRApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}