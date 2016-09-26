using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JimWeb.Startup))]
namespace JimWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
