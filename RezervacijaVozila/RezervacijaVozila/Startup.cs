using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RezervacijaVozila.Startup))]
namespace RezervacijaVozila
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
