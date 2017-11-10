using Newtonsoft.Json;

namespace Xtrf.Api.JobsSmart.Data
{
    public class StepType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("jobTypeId")]
        public int? JobTypeId { get; set; }
        [JsonProperty("semantics")]
        public Semantics Semantics { get; set; }
    }
}
