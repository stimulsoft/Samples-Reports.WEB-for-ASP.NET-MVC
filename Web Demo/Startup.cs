using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Demo.Startup))]
namespace Web_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
