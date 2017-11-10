using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class SmartContacts
    {
        [JsonProperty("additionalIds")]
        public List<object> AdditionalIds { get; set; }

        [JsonProperty("primaryId")]
        public long? PrimaryId { get; set; }
    }
}
