using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class CustomerInvoiceCreate
    {
        [JsonProperty("prepaymentsIds")]
        public List<long> PrePaymentsIds { get; set; }
        [JsonProperty("taskIds")]
        public List<long> TaskIds { get; set; }
        [JsonProperty("type")]
        public InvoiceType Type { get; set; }

    }
}
