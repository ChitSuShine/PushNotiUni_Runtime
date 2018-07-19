using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PushNotiUniService.Startup))]

namespace PushNotiUniService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}