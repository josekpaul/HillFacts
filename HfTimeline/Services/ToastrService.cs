using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HfTimeline.Services
{
    public class ToastrService
    {
        private IJSRuntime _jsRuntime;
        public ToastrService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }
        public async Task ShowInfoMessage()
        {
            await _jsRuntime.InvokeVoidAsync("toastrFunctions.showToastrInfo");
        }
    }
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddBlazorToastr(this IServiceCollection services)
            => services.AddScoped<ToastrService>();
    }
}
