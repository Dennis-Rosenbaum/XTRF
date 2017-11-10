using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class File
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }
    }
}
