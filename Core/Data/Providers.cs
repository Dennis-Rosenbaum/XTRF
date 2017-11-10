using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class Providers: Dictionary<object, object>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }
}
