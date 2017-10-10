using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOC_DependencyInjection.Startup))]
namespace IOC_DependencyInjection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
