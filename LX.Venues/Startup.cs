using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LX.Venues.Startup))]
namespace LX.Venues
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
