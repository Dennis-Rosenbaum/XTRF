using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class LanguageRelation
    {
        [JsonProperty("languageCombinations")]
        public List<Core.Data.LanguageCombination> LanguageCombinations { get; set; }
        [JsonProperty("languages")]
        public List<object> Languages { get; set; }
    }
}
