using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicAccess.Startup))]
namespace PublicAccess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
