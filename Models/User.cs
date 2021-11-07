using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zenkit.Api.Base.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("shortId")]
        public string ShortId { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("displayname")]
        public string Displayname { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }

        [JsonPropertyName("initials")]
        public string Initials { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("backgroundId")]
        public int BackgroundId { get; set; }

        [JsonPropertyName("api_key")]
        public string ApiKey { get; set; }

        [JsonPropertyName("imageLink")]
        public string ImageLink { get; set; }

        [JsonPropertyName("anonymous")]
        public bool Anonymous { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("isSuperAdmin")]
        public bool IsSuperAdmin { get; set; }

        [JsonPropertyName("trello_token")]
        public string TrelloToken { get; set; }

        [JsonPropertyName("isImagePreferred")]
        public bool IsImagePreferred { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> _data { get; set; }
    }
}