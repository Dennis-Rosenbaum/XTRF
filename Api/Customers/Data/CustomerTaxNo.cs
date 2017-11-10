using Newtonsoft.Json;

namespace Xtrf.Api.Customers.Data
{
    public class CustomerTaxNo
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// type (ie. NIP, VAT Reg No, P.IVA) or empty value if unknown
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}