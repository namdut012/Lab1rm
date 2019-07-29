using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1rm.Startup))]
namespace Lab1rm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
