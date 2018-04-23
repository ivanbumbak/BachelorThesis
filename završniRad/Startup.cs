using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(završniRad.Startup))]
namespace završniRad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
