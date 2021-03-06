using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIO.AppMVC.Startup))]
namespace DevIO.AppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
