using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorldASP.Startup))]
namespace HelloWorldASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
