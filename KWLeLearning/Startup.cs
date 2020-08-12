using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KWLeLearning.Startup))]
namespace KWLeLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
