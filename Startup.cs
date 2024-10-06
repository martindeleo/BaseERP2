using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseERP2.Startup))]
namespace BaseERP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
