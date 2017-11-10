using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ProjectStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
