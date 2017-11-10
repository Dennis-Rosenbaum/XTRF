using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ProjectLanguages
    {
        [JsonProperty("languageCombinations")]
        public List<Core.Data.LanguageCombination> LanguageCombinations { get; set; }
        [JsonProperty("sourceLanguageId")]
        public long? SourceLanguageId { get; set; }
        [JsonProperty("specializationId")]
        public long? SpecializationId { get; set; }
        [JsonProperty("targetLanguageIds")]
        public List<long> TargetLanguageIds { get; set; }
    }
}
