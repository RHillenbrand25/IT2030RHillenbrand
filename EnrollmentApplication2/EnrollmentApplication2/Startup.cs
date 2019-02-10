using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnrollmentApplication2.Startup))]
namespace EnrollmentApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
