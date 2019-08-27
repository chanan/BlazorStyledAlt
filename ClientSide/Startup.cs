using BlazorStyled;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ClientSide
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorStyled();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<Core.App>("app");
        }
    }
}
