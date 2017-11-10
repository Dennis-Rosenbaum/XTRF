using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ContentDisposition
    {

        [JsonProperty("creationDate")]
        public DateTime? CreationDate { get; set; }
        [JsonProperty("fileName")]
        public string FileName { get; set; }
        [JsonProperty("modificationDate")]
        public DateTime? ModificationDate { get; set; }
        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }
        [JsonProperty("readDate")]
        public DateTime? ReadDate { get; set; }
        [JsonProperty("size")]
        public long? Size { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
