using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;

using System.IdentityModel.Tokens;
using StarterApi.ConfigurationUtilities;

[assembly: OwinStartup(typeof(StarterApi.Startup))]

namespace StarterApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.UseWebApi(WebApiConfig.Register());

        }
    }
}