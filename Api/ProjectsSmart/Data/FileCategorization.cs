using Newtonsoft.Json;
using System.Collections.Generic;
using Xtrf.Common.Extention;
using Xtrf.Core.Dictionary;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class FileCategorization
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("fileId")]
        public string FileId { get; set; }
        [JsonProperty("languageCombinationIds")]
        public List<Core.Data.LanguageCombination> LanguageCombinationIds { get; set; }
        [JsonProperty("languageIds")]
        public List<long> LanguageIds { get; set; }

        public FileCategorization() { }
        public FileCategorization(FileCategory category, string fileId)
        {
            SetCategory(category);
            FileId = fileId;
        }
        public void SetCategory(FileCategory category) => Category = category.GetName();
    }
}
