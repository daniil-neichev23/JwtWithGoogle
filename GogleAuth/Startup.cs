using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GogleAuth.Startup))]
namespace GogleAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
