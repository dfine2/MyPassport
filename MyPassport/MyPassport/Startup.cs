using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPassport.Startup))]
namespace MyPassport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
