using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D3Visualizations.Services
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
}
