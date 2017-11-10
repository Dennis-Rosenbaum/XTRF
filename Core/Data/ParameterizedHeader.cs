using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class ParameterizedHeader
    {
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }
    }
}
