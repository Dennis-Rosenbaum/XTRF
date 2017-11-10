using Newtonsoft.Json;
using BigDecimal = System.Nullable<long>;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class CustomerInvoice
    {
        [JsonProperty("currencyId")]
        public long? CurrencyId { get; set; }
        [JsonProperty("customerId")]
        public long? CustomerId { get; set; }
        [JsonProperty("dates")]
        public CustomerInvoiceDates Dates { get; set; }
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }
        [JsonProperty("paymentMethodId")]
        public long? PaymentMethodId { get; set; }
        [JsonProperty("paymentTerms")]
        public PaymentTerms PaymentTerms { get; set; }
        //TODO: figure out what kind of enum values the Status types has
        //[JsonProperty("status")]
        //public InvoiceState Status { get; set; }
        [JsonProperty("tasksValue")]
        public BigDecimal TasksValue { get; set; }
        [JsonProperty("totalGross")]
        public BigDecimal TotalGross { get; set; }
        [JsonProperty("totalInWords")]
        public string TotalInWords { get; set; }
        [JsonProperty("totalNetto")]
        public BigDecimal TotalNetto { get; set; }
        [JsonProperty("type")]
        public InvoiceType Type { get; set; }
        //TODO: figure out what kind of enum values the Vat CalculationRule has
        //[JsonProperty("vatCalculationRule")]
        //public VATCalculationRule VatCalculationRule { get; set; }
    }
}
