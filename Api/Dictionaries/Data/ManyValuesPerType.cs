using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.Dictionaries.Data
{
    public class ManyValuesPerType
    {
        [JsonProperty("category")]
        public List<Category> Category { get; set; }
        [JsonProperty("country")]
        public List<Country> Country { get; set; }
        [JsonProperty("currency")]
        public List<Currency> Currency { get; set; }
        [JsonProperty("industry")]
        public List<Industry> Industry { get; set; }
        [JsonProperty("language")]
        public List<Language> Language { get; set; }
        [JsonProperty("leadSource")]
        public List<LeadSource> LeadSource { get; set; }
        [JsonProperty("personDepartment")]
        public List<PersonDepartment> PersonDepartment { get; set; }
        [JsonProperty("personPosition")]
        public List<PersonPosition> PersonPosition { get; set; }
        [JsonProperty("province")]
        public List<Province> Province { get; set; }
        [JsonProperty("specialization")]
        public List<LanguageSpecialization> Specialization { get; set; }
    }
}
