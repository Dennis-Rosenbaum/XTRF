using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Files
    {
        [JsonProperty("sharedWorkFiles")]
        public List<string> SharedWorkFiles { get; set; }
        [JsonProperty("sharedReferenceFiles")]
        public List<string> SharedReferenceFiles { get; set; }
        [JsonProperty("deliveredInJobFiles")]
        public List<string> DeliveredInJobFiles { get; set; }
    }
}
