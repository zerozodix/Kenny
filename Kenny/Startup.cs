using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Kenny.Startup))]

namespace Kenny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Method intentionally left empty.
        }
    }
}
