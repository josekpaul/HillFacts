using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorStrap;
using Blazor.Analytics;
using D3Visualizations.Services;
using JSEmbed.Services;
using HillFacts.Client.Services;
using HillFacts.Client.ViewModels;

namespace HillFacts.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var http = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => http);
            builder.Services.AddBootstrapCss();
            builder.Services.AddGoogleAnalytics("G-TN4Z59Z2QV");
            builder.Services.AddD3Visualizations();
            builder.Services.AddJsEmbed();
            builder.Services.AddSingleton<IAppCacheService>(new AppCacheService(http));

            builder.Services.AddScoped<IMembersViewModel, MembersViewModel>();
            builder.Services.AddScoped<IMemberDetailViewModel, MemberDetailViewModel>();
            builder.Services.AddScoped<ILobbyingViewModel, LobbyingViewModel>();
            builder.Services.AddScoped<ICampFiSearchViewModel, CampFiSearchViewModel>();
            builder.Services.AddScoped<ICampFiCandidateViewModel, CampFiCandidateViewModel>();
            builder.Services.AddScoped<ICampaignComparisonViewModel, CampaignComparisonViewModel>();
            await builder.Build().RunAsync();
        }
    }
}
