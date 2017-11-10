using Newtonsoft.Json;
using Xtrf.Core.Data;

namespace Xtrf.Api.Vendors.Data
{
    public class Provider
    {
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }
        [JsonProperty("branchId")]
        public long? BranchId { get; set; }
        [JsonProperty("competencies")]
        public Competencies Competencies { get; set; }
        [JsonProperty("contact")]
        public Contact Contact { get; set; }
        [JsonProperty("correspondenceAddress")]
        public Address CorrespondenceAddress { get; set; }
        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }
        [JsonProperty("leadSourceId")]
        public long? LeadSourceId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        //[JsonProperty("persons")]
        //public List<eu.xtrf.api.dto.providerPerson.ProviderPersonDTO> Persons { get; set; }
        //[JsonProperty("status")]
        //public ProviderStatus Status { get; set; }
    }
}
