using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFRelations.Startup))]
namespace EFRelations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
