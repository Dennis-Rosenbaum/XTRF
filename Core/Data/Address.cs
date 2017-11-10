using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class Address
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("countryId")]
        public long? CountryId { get; set; }
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("provinceId")]
        public long? ProvinceId { get; set; }
        [JsonProperty("sameAsBillingAddress")]
        public bool? SameAsBillingAddress { get; set; }
    }
}
