using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class CustomerInvoiceCreateResult
    {
        [JsonProperty("invoiceIds")]
        public List<long> InvoiceIds { get; set; }
        [JsonProperty("invoiceUrl")]
        public string InvoiceUrl { get; set; }
    }
}
