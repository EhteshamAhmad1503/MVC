using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookSignUp.Startup))]
namespace FacebookSignUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
