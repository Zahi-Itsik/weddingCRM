using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(weddingCRM.Startup))]
namespace weddingCRM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
