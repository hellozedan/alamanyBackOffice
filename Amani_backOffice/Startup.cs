using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amani_backOffice.Startup))]
namespace Amani_backOffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
