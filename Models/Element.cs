using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{
    public class Element
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("shortId")]
        public string ShortId { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; }

        [JsonPropertyName("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonPropertyName("isAutoCreated")]
        public bool IsAutoCreated { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("deprecated_at")]
        public string DeprecatedAt { get; set; }

        [JsonPropertyName("elementcategory")]
        public int Elementcategory { get; set; }

        [JsonPropertyName("listId")]
        public int ListId { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}