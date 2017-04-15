using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHSAuction.Startup))]
namespace CHSAuction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
