using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_DemoFx.Startup))]
namespace Web_DemoFx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
