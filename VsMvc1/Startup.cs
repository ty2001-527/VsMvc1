using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VsMvc1.Startup))]
namespace VsMvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
