using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zenkit.Base.Api
{
    public static class HttpContentExtensions
    {
        public static JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions {
            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
        };

        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent content)
        {
            string json = await content.ReadAsStringAsync();
            T value = JsonSerializer.Deserialize<T>(json, jsonSerializerOptions);
            return value;
        }
    }
}