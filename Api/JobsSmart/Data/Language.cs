using Newtonsoft.Json;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Language
    {
        [JsonProperty("sourceLanguageId")]
        public int? SourceLanguageId { get; set; }
        [JsonProperty("targetLanguageId")]
        public int? TargetLanguageId { get; set; }
        [JsonProperty("specializationId")]
        public int? SpecializationId { get; set; }
    }
}
