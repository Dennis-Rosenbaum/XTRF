using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Documents
    {
        [JsonProperty("projectConfirmationStatus")]
        public string ProjectConfirmationStatus { get; set; }
    }
}
