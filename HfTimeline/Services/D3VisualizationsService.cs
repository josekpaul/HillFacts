using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System;

namespace D3Visualizations.Services
{
    public class D3VisualizationsService
    {
        private IJSRuntime _jsRuntime;
        public D3VisualizationsService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task DrawTreemap(TreemapInput d, ElementReference element)
        {
            await _jsRuntime.InvokeVoidAsync("d3VisualizationFunctions.drawTreemap", d, element);
        }

        public async Task DrawStackedColumnChart(DataTable d, ElementReference element, object dotnetObject, string callbackFunction)
        {
            await _jsRuntime.InvokeVoidAsync("d3VisualizationFunctions.drawStackedColumnChart", ToCsv(d), categoryColumn, element);
        }

        public async Task DrawStackedColumnChart(DataTable d, ElementReference element)
        {
            await DrawStackedColumnChart(d, d.Columns[0].ColumnName, element);
        }


        static string ToCsv(DataTable dtDataTable)
        {
            StringBuilder sb = new StringBuilder();
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sb.Append(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sb.Append(',');
                }
            }
            sb.Append("\n");
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sb.Append(value);
                        }
                        else
                        {
                            sb.Append(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

    }

    public class TreemapInput
    {
        public string Name { get; set; }
        public List<TreemapInput> Children { get; set; }
        public double? Value { get; set; }
    }

}