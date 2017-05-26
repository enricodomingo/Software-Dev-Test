using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SureFire.Startup))]
namespace SureFire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
