using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class TargetLanguages
    {
        [JsonProperty("targetLanguageIds")]
        public List<long> TargetLanguageIds { get; set; }
    }
}
