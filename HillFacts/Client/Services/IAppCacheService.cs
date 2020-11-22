using System.Threading.Tasks;

namespace HillFacts.Client.Services
{
    public interface IAppCacheService
    {
        Task<T> CallCacheableServerMethod<T>(string query);
        T GetValue<T>(string key);
        void SetValue(string key, object value);
    }
}