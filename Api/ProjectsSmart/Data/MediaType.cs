using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class MediaType
    {
        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }
        [JsonProperty("subtype")]
        public string Subtype { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("wildcardSubtype")]
        public bool? WildcardSubtype { get; set; }
        [JsonProperty("wildcardType")]
        public bool? WildcardType { get; set; }
    }
}
