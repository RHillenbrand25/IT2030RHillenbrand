using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab8AuthWithGoogle.Startup))]
namespace Lab8AuthWithGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
