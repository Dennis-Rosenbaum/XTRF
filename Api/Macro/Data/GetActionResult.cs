using Newtonsoft.Json;

namespace Xtrf.Api.Macro.Data
{
    public class GetActionResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
