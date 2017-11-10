using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class FileCategorizations
    {
        [JsonProperty("files")]
        public List<FileCategorization> Files { get; set; }

        public FileCategorizations() { }
        public FileCategorizations(FileCategorization file)
        {
            Files = new List<FileCategorization>() { file };
        }
    }
}
