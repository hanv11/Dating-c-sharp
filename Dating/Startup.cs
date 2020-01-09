using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dating.Startup))]
namespace Dating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
