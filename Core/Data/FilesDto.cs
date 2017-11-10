using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class FilesDto
    {
        [JsonProperty("files")]
        public List<string> Files { get; set; }

        public FilesDto() { }
        public FilesDto(string fileId)
        {
            Files = new List<string>() { fileId };
        }
    }
}
