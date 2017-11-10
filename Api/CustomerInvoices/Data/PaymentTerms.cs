using Newtonsoft.Json;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class PaymentTerms
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
