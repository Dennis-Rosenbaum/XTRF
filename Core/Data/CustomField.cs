using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class CustomField
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }

    }
}
