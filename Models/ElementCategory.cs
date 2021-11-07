using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{
    public class ElementCategory
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

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("placeholderSchema")]
        public string PlaceholderSchema { get; set; }

        [JsonPropertyName("container")]
        public bool Container { get; set; }

        [JsonPropertyName("listable")]
        public bool Listable { get; set; }

        [JsonPropertyName("filterable")]
        public bool Filterable { get; set; }

        [JsonPropertyName("sortKey")]
        public string SortKey { get; set; }

        [JsonPropertyName("searchable")]
        public bool Searchable { get; set; }

        [JsonPropertyName("isStatic")]
        public bool IsStatic { get; set; }

        [JsonPropertyName("minWidth")]
        public string MinWidth { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("maxWidth")]
        public string MaxWidth { get; set; }

        [JsonPropertyName("isWidthFixed")]
        public bool IsWidthFixed { get; set; }

        [JsonPropertyName("canSet")]
        public bool CanSet { get; set; }

        [JsonPropertyName("canAdd")]
        public bool CanAdd { get; set; }

        [JsonPropertyName("canRemove")]
        public bool CanRemove { get; set; }

        [JsonPropertyName("canReplace")]
        public bool CanReplace { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("deprecated_at")]
        public string DeprecatedAt { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}