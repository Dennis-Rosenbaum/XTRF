using Newtonsoft.Json;

namespace Xtrf.Api.Services.Data
{
    public class Service
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }
        [JsonProperty("default")]
        public bool? Default { get; set; }
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preferred")]
        public bool? Preferred { get; set; }
    }
}
