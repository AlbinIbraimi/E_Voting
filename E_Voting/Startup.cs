using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Voting.Startup))]
namespace E_Voting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
