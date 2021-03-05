using System.Threading.Tasks;

namespace AppTemplate.Core.Data
{
    public interface IJsonSerializer
    {
        Task<T> Deserialize<T>(string json);
        Task<string> Serialize<T>(T obj);
    }
}
