using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrameworkOne.Web.Startup))]
namespace FrameworkOne.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
