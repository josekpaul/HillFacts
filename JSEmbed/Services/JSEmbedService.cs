using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JSEmbed.Services
{
    public class JSEmbedService
    {
        private IJSRuntime _jsRuntime;
        public JSEmbedService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }
        public async Task RunRemoteJS(string sourceUrl, string onLoadHandler = null, string nonce = null)
        {
            await _jsRuntime.InvokeVoidAsync("jsEmbed.runRemoteJs", sourceUrl, onLoadHandler, nonce);
        }
    }
}
