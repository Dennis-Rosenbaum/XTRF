using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class RemoteCatToolReferences
    {
        [JsonProperty("catResourceId")]
        public string CatResourceId { get; set; }
        [JsonProperty("catToolDocumentId")]
        public string CatToolDocumentId { get; set; }
        [JsonProperty("editorUrl")]
        public string EditorUrl { get; set; }
    }
}
