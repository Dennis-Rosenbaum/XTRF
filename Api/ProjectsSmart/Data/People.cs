using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class People
    {
        [JsonProperty("projectManagerId")]
        public long? ProjectManagerId { get; set; }
    }
}
