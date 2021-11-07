using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{
    public class Entry
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
        public string DeprecatedAt { get; set; }

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
        public string DeprecatedBy { get; set; }

        [JsonPropertyName("displayString")]
        public string DisplayString { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }

        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        [JsonPropertyName("checklists")]
        public List<Checklist> Checklists { get; set; }
    }
}