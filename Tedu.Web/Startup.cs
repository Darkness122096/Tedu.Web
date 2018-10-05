using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tedu.Web.Startup))]
namespace Tedu.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
