using Newtonsoft.Json;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Semantics
    {
        [JsonProperty("isScripted")]
        public bool? IsScripted { get; set; }

        [JsonProperty("canVerifyFiles")]
        public bool? CanVerifyFiles { get; set; }
    }
}
