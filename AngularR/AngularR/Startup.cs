using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularR.Startup))]
namespace AngularR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
