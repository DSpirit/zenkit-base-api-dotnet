using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{
    public class FilterResponse
    {
        [JsonPropertyName("countData")]
        public CountData CountData { get; set; }

        [JsonPropertyName("countDataPerGroup")]
        public List<CountData> CountDataPerGroup { get; set; }

        [JsonPropertyName("listEntries")]
        public List<ListEntry> ListEntries { get; set; }
    }

    public class CountData
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("filteredTotal")]
        public int FilteredTotal { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}