using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Specialization
    {
        [JsonProperty("specializationId")]
        public long? SpecializationId { get; set; }
    }
}
