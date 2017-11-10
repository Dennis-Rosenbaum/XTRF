using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class FileArchive
    {
        [JsonProperty("archiveUrl")]
        public string ArchiveUrl { get; set; }
    }
}
