using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductCategoryWeb.Startup))]
namespace ProductCategoryWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
