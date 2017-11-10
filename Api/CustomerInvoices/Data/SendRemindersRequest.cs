using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class SendRemindersRequest
    {
        [JsonProperty("ids")]
        public List<long> Ids { get; set; }
    }
}
