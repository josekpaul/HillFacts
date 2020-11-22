using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HillFacts.Client.Services
{
    public class AppCacheService : IAppCacheService
    {
        Dictionary<string, object> AppState;
        readonly HttpClient Http;

        public AppCacheService(HttpClient http)
        {
            AppState = new Dictionary<string, object>();
            Http = http;
        }

        public T GetValue<T>(string key)
        {
            if (AppState.ContainsKey(key))
            {
                try
                {
                    return (T)AppState[key];
                }
                catch { }
            }
            return default(T);
        }

        public void SetValue(string key, object value)
        {
            if (AppState.ContainsKey(key))
            {
                AppState[key] = value;
            }
            else
            {
                AppState.Add(key, value);
            }
        }

        public async Task<T> CallCacheableServerMethod<T>(string query)
        {
            var b = GetValue<T>(query);
            if (b == null)
            {
                b = await Http.GetFromJsonAsync<T>(query);
                SetValue(query, b);
            }
            return b;
        }
    }
}
