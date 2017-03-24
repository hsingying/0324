using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0317.Startup))]
namespace _0317
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
