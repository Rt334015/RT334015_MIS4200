using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RT334015_MIS4200.Startup))]
namespace RT334015_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
