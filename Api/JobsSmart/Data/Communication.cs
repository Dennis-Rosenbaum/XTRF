using Newtonsoft.Json;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Communication
    {
        [JsonProperty("instructionsForAllJobs")]
        public string InstructionsForAllJobs { get; set; }
        [JsonProperty("instructionsForJob")]
        public string InstructionsForJob { get; set; }
        [JsonProperty("noteFromVendor")]
        public string NoteFromVendor { get; set; }
    }
}
