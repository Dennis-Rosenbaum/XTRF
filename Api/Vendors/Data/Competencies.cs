using Newtonsoft.Json;
using Xtrf.Core.Data;
using System.Collections.Generic;

namespace Xtrf.Api.Vendors.Data
{
    public class Competencies
    {
        [JsonProperty("languageCombinations")]
        public List<LanguageCombination> LanguageCombinations { get; set; }
    }
}
