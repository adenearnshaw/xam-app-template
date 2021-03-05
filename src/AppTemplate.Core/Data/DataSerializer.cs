using System.Threading.Tasks;
using System.Text.Json;
using JSON = System.Text.Json.JsonSerializer;

namespace AppTemplate.Core.Data
{
    public class JsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;

        public JsonSerializer()
        {
            _options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public Task<T> Deserialize<T>(string json)
        {
            var obj = JSON.Deserialize<T>(json, _options);
            return Task.FromResult(obj);
        }

        public Task<string> Serialize<T>(T obj)
        {
            var jsonString = JSON.Serialize(obj, _options);
            return Task.FromResult(jsonString);
        }
    }
}
