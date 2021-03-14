using System.Threading.Tasks;

namespace BlazorLocalStorageExample.Utils
{
    public interface ILocalStorage
    {
       Task SetAsync<T>(string key, T value);
       Task<T> GetAsync<T>(string key);
    }
}
