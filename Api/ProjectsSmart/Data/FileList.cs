using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class FileList
    {
        [JsonProperty("files")]
        public List<string> Files { get; set; }
    }
}
