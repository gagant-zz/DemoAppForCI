using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAppForCI.Startup))]
namespace DemoAppForCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
