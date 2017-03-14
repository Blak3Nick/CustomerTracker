using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerTracker.Startup))]
namespace CustomerTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
