using Microsoft.Extensions.DependencyInjection;

namespace D3Visualizations.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddD3Visualizations(this IServiceCollection services)
            => services.AddScoped<D3VisualizationsService>();
    }
}
