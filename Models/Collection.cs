using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Base.Api.Models
{
    public class Collection
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("shortId")]
        public string ShortId { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("itemName")]
        public string ItemName { get; set; }

        [JsonPropertyName("isBuilding")]
        public bool IsBuilding { get; set; }

        [JsonPropertyName("isMigrating")]
        public bool IsMigrating { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }

        [JsonPropertyName("formulaTSortOrder")]
        public string FormulaTSortOrder { get; set; }

        [JsonPropertyName("listFilePolicy")]
        public string ListFilePolicy { get; set; }

        [JsonPropertyName("originProvider")]
        public string OriginProvider { get; set; }
        
        [JsonPropertyName("defaultViewModus")]
        public int DefaultViewModus { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("deprecated_at")]
        public string DeprecatedAt { get; set; }

        [JsonPropertyName("origin_created_at")]
        public DateTime OriginCreatedAt { get; set; }

        [JsonPropertyName("origin_updated_at")]
        public string OriginUpdatedAt { get; set; }

        [JsonPropertyName("origin_deprecated_at")]
        public string OriginDeprecatedAt { get; set; }

        [JsonPropertyName("workspaceId")]
        public int WorkspaceId { get; set; }

        [JsonPropertyName("backgroundId")]
        public string BackgroundId { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonPropertyName("iconColor")]
        public string IconColor { get; set; }

        [JsonPropertyName("iconBackgroundColor")]
        public string IconBackgroundColor { get; set; }

        [JsonPropertyName("imageId")]
        public int ImageId { get; set; }

        [JsonPropertyName("coverImageId")]
        public int CoverImageId { get; set; }

        [JsonPropertyName("scheduled_for_deletion_at")]
        public string ScheduledForDeletionAt { get; set; }

        [JsonPropertyName("frozen_at")]
        public string FrozenAt { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}