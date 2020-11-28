using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace D3Visualizations.Services
{
    public class D3VisualizationsService
    {
        private IJSRuntime _jsRuntime;
        public D3VisualizationsService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }
        public async Task DrawTreemap()
        {
            var d = JsonSerializer.Deserialize<TreemapInput>(@"{ ""Children"": [{ ""Name"": ""boss1"", ""Children"": [{ ""Name"": ""mister_a"", ""Group"": ""A"", ""Value"": 28, ""ColName"": ""level3"" }, { ""Name"": ""mister_b"", ""Group"": ""A"", ""Value"": 19, ""ColName"": ""level3"" }, { ""Name"": ""mister_c"", ""Group"": ""C"", ""Value"": 18, ""ColName"": ""level3"" }, { ""Name"": ""mister_d"", ""Group"": ""C"", ""Value"": 19, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss2"", ""Children"": [{ ""Name"": ""mister_e"", ""Group"": ""C"", ""Value"": 14, ""ColName"": ""level3"" }, { ""Name"": ""mister_f"", ""Group"": ""A"", ""Value"": 11, ""ColName"": ""level3"" }, { ""Name"": ""mister_g"", ""Group"": ""B"", ""Value"": 15, ""ColName"": ""level3"" }, { ""Name"": ""mister_h"", ""Group"": ""B"", ""Value"": 16, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss3"", ""Children"": [{ ""Name"": ""mister_i"", ""Group"": ""B"", ""Value"": 10, ""ColName"": ""level3"" }, { ""Name"": ""mister_j"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_k"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_l"", ""Group"": ""D"", ""Value"": 25, ""ColName"": ""level3"" }, { ""Name"": ""mister_m"", ""Group"": ""D"", ""Value"": 16, ""ColName"": ""level3"" }, { ""Name"": ""mister_n"", ""Group"": ""D"", ""Value"": 28, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }], ""Name"": ""CEO"" }");
            await _jsRuntime.InvokeVoidAsync("d3VisualizationFunctions.drawTreemap", d);
        }
        public async Task DrawTreemap(ElementReference element)
        {
            var d = JsonSerializer.Deserialize<TreemapInput>(@"{ ""Children"": [{ ""Name"": ""boss1"", ""Children"": [{ ""Name"": ""mister_a"", ""Group"": ""A"", ""Value"": 28, ""ColName"": ""level3"" }, { ""Name"": ""mister_b"", ""Group"": ""A"", ""Value"": 19, ""ColName"": ""level3"" }, { ""Name"": ""mister_c"", ""Group"": ""C"", ""Value"": 18, ""ColName"": ""level3"" }, { ""Name"": ""mister_d"", ""Group"": ""C"", ""Value"": 19, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss2"", ""Children"": [{ ""Name"": ""mister_e"", ""Group"": ""C"", ""Value"": 14, ""ColName"": ""level3"" }, { ""Name"": ""mister_f"", ""Group"": ""A"", ""Value"": 11, ""ColName"": ""level3"" }, { ""Name"": ""mister_g"", ""Group"": ""B"", ""Value"": 15, ""ColName"": ""level3"" }, { ""Name"": ""mister_h"", ""Group"": ""B"", ""Value"": 16, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }, { ""Name"": ""boss3"", ""Children"": [{ ""Name"": ""mister_i"", ""Group"": ""B"", ""Value"": 10, ""ColName"": ""level3"" }, { ""Name"": ""mister_j"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_k"", ""Group"": ""A"", ""Value"": 13, ""ColName"": ""level3"" }, { ""Name"": ""mister_l"", ""Group"": ""D"", ""Value"": 25, ""ColName"": ""level3"" }, { ""Name"": ""mister_m"", ""Group"": ""D"", ""Value"": 16, ""ColName"": ""level3"" }, { ""Name"": ""mister_n"", ""Group"": ""D"", ""Value"": 28, ""ColName"": ""level3"" }], ""ColName"": ""level2"" }], ""Name"": ""CEO"" }");
            await _jsRuntime.InvokeVoidAsync("d3VisualizationFunctions.drawTreemap", d, element);
        }
        public async Task DrawTreemap(TreemapInput d, ElementReference element)
        {
            await _jsRuntime.InvokeVoidAsync("d3VisualizationFunctions.drawTreemap", d, element);
        }
    }

    public class TreemapInput
    {
        public string Name { get; set; }
        public List<TreemapInput> Children { get; set; }
        public int? Value { get; set; }
        public string Group { get; set; }
        public string ColName { get; set; }
    }
}