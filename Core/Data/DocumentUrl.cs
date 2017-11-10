using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class DocumentUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
