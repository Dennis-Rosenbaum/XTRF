using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ProjectCreate
    {
        [JsonProperty("clientId")]
        public long? ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set;}

        [JsonProperty("serviceId")]
        public long? ServiceId { get; set; }
    }
}
