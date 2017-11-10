using Newtonsoft.Json;
using Xtrf.Core.Data;
using System.Collections.Generic;

namespace Xtrf.Api.Customers.Data
{
    public class CustomerPerson
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }
        [JsonProperty("contact")]
        public PersonContact Contact { get; set; }
        [JsonProperty("customerId")]
        public long? CustomerId { get; set; }
        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("motherTonguesIds")]
        public List<object> MotherTonguesIds { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("positionId")]
        public long? PositionId { get; set; }

        public void SetGender(Gender g)
        {
            if (g == Core.Data.Gender.UNKNOWN)
                Gender = null;
            if (g == Core.Data.Gender.MALE)
                Gender = "MALE";
            if (g == Core.Data.Gender.FEMALE)
                Gender = "FEMALE";
        }

        public CustomerPerson CreateNew(string name, long customerId, string email)
        {
            return new CustomerPerson()
            {
                Name = name,
                CustomerId = customerId,
                Contact = new PersonContact() { Emails = new CustomerContactEmails() { Primary = email } },
            };
        }
    }
}
