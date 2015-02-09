using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBWebsite.Startup))]
namespace SBWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
