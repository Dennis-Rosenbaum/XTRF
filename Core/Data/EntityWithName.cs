using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class EntityWithName
    {
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
