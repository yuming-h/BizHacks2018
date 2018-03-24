using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizHacksApp.Startup))]
namespace BizHacksApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
