using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObjectTestMVC.Startup))]
namespace ObjectTestMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
