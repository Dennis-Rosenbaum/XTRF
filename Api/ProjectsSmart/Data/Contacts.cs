using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Contacts
    {
        [JsonProperty("additionalIds")]
        public List<object> AdditionalIds { get; set; }

        [JsonProperty("primaryId")]
        public long? PrimaryId { get; set; }

        [JsonProperty("sendBackToId")]
        public long? SendBackToId { get; set; }
    }
}
