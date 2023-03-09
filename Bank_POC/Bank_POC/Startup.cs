using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bank_POC.Startup))]
namespace Bank_POC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
