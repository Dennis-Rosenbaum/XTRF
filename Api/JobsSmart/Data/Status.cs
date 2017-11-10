using Newtonsoft.Json;
using Xtrf.Common.Extention;
using Xtrf.Core.Dictionary;

namespace Xtrf.Api.JobsSmart.Data
{
    public class AddJobStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        public AddJobStatus() { }
        public AddJobStatus(JobStatus status)
        {
            Status = status.GetName();
        }
    }
}
