using Microsoft.Extensions.DependencyInjection;

namespace JSEmbed.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddJsEmbed(this IServiceCollection services)
            => services.AddScoped<JSEmbedService>();



    }
}
