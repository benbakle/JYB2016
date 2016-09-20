using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JYB2016.Startup))]
namespace JYB2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
