using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.Customers.Data
{
    public class CustomerAccounting
    {
        [JsonProperty("taxNumbers")]
        public List<CustomerTaxNo> TaxNumbers { get; set; }
    }
}
