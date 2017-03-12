using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ho.Startup))]
namespace ho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
