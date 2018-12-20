using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalizationAndLocalization.Startup))]
namespace GlobalizationAndLocalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
