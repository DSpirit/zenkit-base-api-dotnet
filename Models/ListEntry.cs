using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Api.Base.Models
{
    public class ListEntry
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("shortId")]
        public string ShortId { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("listId")]
        public int ListId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("deprecated_at")]
        public object DeprecatedAt { get; set; }

        [JsonPropertyName("origin_created_at")]
        public object OriginCreatedAt { get; set; }

        [JsonPropertyName("origin_updated_at")]
        public object OriginUpdatedAt { get; set; }

        [JsonPropertyName("origin_deprecated_at")]
        public object OriginDeprecatedAt { get; set; }

        [JsonPropertyName("created_by_displayname")]
        public string CreatedByDisplayname { get; set; }

        [JsonPropertyName("updated_by_displayname")]
        public string UpdatedByDisplayname { get; set; }

        [JsonPropertyName("deprecated_by_displayname")]
        public string DeprecatedByDisplayname { get; set; }

        [JsonPropertyName("created_by")]
        public int CreatedBy { get; set; }

        [JsonPropertyName("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonPropertyName("deprecated_by")]
        public object DeprecatedBy { get; set; }

        [JsonPropertyName("displayString")]
        public string DisplayString { get; set; }

        [JsonPropertyName("sortOrder")]
        public string SortOrder { get; set; }

        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        [JsonPropertyName("checklists")]
        public List<Checklist> Checklists { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}