using Newtonsoft.Json;

namespace Xtrf.Api.Macro.Data
{
    public class RunMacro
    {
        [JsonProperty("actionId")]
        public string ActionId { get; set; }
        [JsonProperty("statusUrl")]
        public string StatusUrl { get; set; }
        [JsonProperty("resultUrl")]
        public string ResultUrl { get; set; }
    }
}
