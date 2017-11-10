using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class LanguageCombination
    {
        [JsonProperty("sourceLanguageId")]
        public long? SourceLanguageId { get; set; }
        [JsonProperty("targetLanguageId")]
        public long? TargetLanguageId { get; set; }
    }
}
