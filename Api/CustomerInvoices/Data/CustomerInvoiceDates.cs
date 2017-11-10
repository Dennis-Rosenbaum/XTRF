using Newtonsoft.Json;
using Xtrf.Core.Data;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class CustomerInvoiceDates
    {
        [JsonProperty("draftDate")]
        public Time DraftDate { get; set; }

        [JsonProperty("finalDate")]
        public Time FinalDate { get; set; }
        [JsonProperty("invoiceDate")]
        public Time InvoiceDate { get; set; }
        [JsonProperty("paymentDueDate")]
        public Time PaymentDueDate { get; set; }
    }
}
