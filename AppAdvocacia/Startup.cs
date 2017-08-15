using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppAdvocacia.Startup))]
namespace AppAdvocacia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
