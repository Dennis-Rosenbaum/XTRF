using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class EmptyHolder
    {
        [JsonProperty("empty")]
        public bool? Empty { get; set; }
    }
}