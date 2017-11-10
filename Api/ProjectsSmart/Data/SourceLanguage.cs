using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class SourceLanguage
    {
        [JsonProperty("sourceLanguageId")]
        public long? SourceLanguageId { get; set; }
    }
}
