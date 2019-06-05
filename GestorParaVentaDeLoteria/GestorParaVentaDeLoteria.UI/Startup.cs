using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestorParaVentaDeLoteria.UI.Startup))]
namespace GestorParaVentaDeLoteria.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
