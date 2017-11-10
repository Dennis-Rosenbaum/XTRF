using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class CustomerContactEmails
    {
        [JsonProperty("additional")]
        public List<string> Additional { get; set; }
        [JsonProperty("cc")]
        public List<string> Cc { get; set; }
        [JsonProperty("primary")]
        public string Primary { get; set; }
    }
}