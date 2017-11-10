using Newtonsoft.Json;

namespace Xtrf.Api.Customers.Data
{
    public class CustomerResponsiblePersons
    {
        [JsonProperty("accountManagerId")]
        public long? AccountManagerId { get; set; }
        [JsonProperty("projectCoordinatorId")]
        public long? ProjectCoordinatorId { get; set; }
        [JsonProperty("projectManagerId")]
        public long? ProjectManagerId { get; set; }
        [JsonProperty("salesPersonId")]
        public long? SalesPersonId { get; set; }
    }
}