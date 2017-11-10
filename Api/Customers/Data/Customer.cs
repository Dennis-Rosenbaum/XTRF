using Newtonsoft.Json;
using System.Collections.Generic;
using Xtrf.Core.Data;

namespace Xtrf.Api.Customers.Data
{
    public class CustomerStatus
    {
        public const string Active = "ACTIVE";
        public const string Potential = "POTENTIAL";
        public const string InActive = "INACTIVE";
    }

    public class Customer
    {
        [JsonProperty("accounting")]
        public CustomerAccounting Accounting { get; set; }
        [JsonProperty("accountOnCustomerServer")]
        public string AccountOnCustomerServer { get; set; }
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }
        [JsonProperty("branchId")]
        public long? BranchId { get; set; }
        [JsonProperty("categoriesIds")]
        public Categories CategoriesIds	 { get; set; }
        [JsonProperty("contact")]
        public Contact Contact  { get; set; }
        [JsonProperty("contractNumber")]
        public string ContractNumber  { get; set; }
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
        [JsonProperty("industriesIds")]
        public Industries IndustriesIds { get; set; }
        [JsonProperty("leadSourceId")]
        public long? LeadSourceId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("persons")]
        public List<CustomerPerson> Persons { get; set; }
        [JsonProperty("responsiblePersons")]
        public CustomerResponsiblePersons ResponsiblePersons { get; set; }
        [JsonProperty("salesNotes")]
        public string SalesNotes { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

        public Customer() { }
        public Customer(string companyName, string email, string address, string city, long countryId)
        {
            Name = companyName;
            FullName = companyName;
            Contact = new Contact() { Emails = new CustomerContactEmails() { Primary = email } };
            BillingAddress = new Address()
            {
                AddressLine1 = address,
                City = city,
                CountryId = countryId
            };
        }
    }
}
