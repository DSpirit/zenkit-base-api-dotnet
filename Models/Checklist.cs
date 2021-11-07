using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Api.Base.Models
{
    public class Checklist
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("shouldCheckedItemsBeHidden")]
        public bool ShouldCheckedItemsBeHidden { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}