using System.Collections.Generic;
using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Customers.Data;
using Xtrf.Api.Customers.Params;
using Xtrf.Core.Data;
using Xtrf.Core.Params;

namespace Xtrf.Api.Customers
{
    public class CustomerContext : ContextBase
    {
        internal CustomerContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        public Task<XtrfResult<Customer>> CreateNew(Customer newCustomer)
            => Post<Customer>(new ExecuteParams("/customers", newCustomer));

        public Task<XtrfResult<CustomerPerson>> CreateNewPerson(CustomerPerson newPerson)
            => Post<CustomerPerson>(new ExecuteParams("/customers/persons", newPerson));
        
        public Task<XtrfResult<AccessToken>> CreatePersonToken(AccessTokenRequest request)
            => Post<AccessToken>(new ExecuteParams("/customers/persons/accessToken", request));
        #endregion

        #region GET
        public Task<XtrfResult<EntityWithNames>> GetAll(UpdatedSinceParameter param = null)
            => Get<EntityWithNames> (new ExecuteParams($"/customers/", param));

        public Task<XtrfResult<List<int>>> GetAllIds(GetIdsParameter param = null)
            => Get<List<int>>(new ExecuteParams($"/customers/ids", param));

        public Task<XtrfResult<List<int>>> GetPersonIds(UpdatedSinceParameter param)
            => Get<List<int>>(new ExecuteParams($"/customers/persons/ids", param));

        public Task<XtrfResult<CustomerPerson>> GetPerson(long personId)
            => Get<CustomerPerson>(new ExecuteParams($"/customers/persons/{personId}"));

        public Task<XtrfResult<PersonContact>> GetPersonContact(long personId)
            => Get<PersonContact>(new ExecuteParams($"/customers/persons/{personId}/contact"));

        public Task<XtrfResult<CustomFields>> GetPersonCustomFields(long personId)
            => Get<CustomFields>(new ExecuteParams($"/customers/persons/{personId}/customFields"));

        public Task<XtrfResult<Customer>> GetCustomer(long customerId)
            => Get<Customer>(new ExecuteParams($"/customers/{customerId}"));

        public Task<XtrfResult<Customer>> GetCustomerWithPersons(long customerId)
            => Get<Customer>(new ExecuteParams($"/customers/{customerId}", new GetWithPersonsParameter("persons")));

        public Task<XtrfResult<Address>> GetCustomerAddress(long customerId)
            => Get<Address>(new ExecuteParams($"/customers/{customerId}/address"));

        public Task<XtrfResult<Categories>> GetCustomerCategories(long customerId)
            => Get<Categories>(new ExecuteParams($"/customers/{customerId}/categories"));

        public Task<XtrfResult<Contact>> GetCustomerContact(long customerId)
            => Get<Contact>(new ExecuteParams($"/customers/{customerId}/contact"));

        public Task<XtrfResult<Address>> GetCustomerCorrespondenceAddress(long customerId)
            => Get<Address>(new ExecuteParams($"/customers/{customerId}/correspondenceAddress"));

        public Task<XtrfResult<CustomFields>> GetCustomerCustomFields(long customerId)
            => Get<CustomFields>(new ExecuteParams($"/customers/{customerId}/customFields"));

        public Task<XtrfResult<CustomField>> GetCustomerCustomField(long customerId, string customFieldKey)
            => Get<CustomField>(new ExecuteParams($"/customers/{customerId}/customFields/{customFieldKey}"));

        public Task<XtrfResult<Industries>> GetCustomerIndustries(long customerId)
            => Get<Industries>(new ExecuteParams($"/customers/{customerId}/industries"));
        #endregion

        #region PUT
        public Task<XtrfResult<CustomerPerson>> UpdatePerson(long personId, CustomerPerson person)
        {
            if((person?.Contact?.Phones?.Count ?? 0) > 3)
            {
                person.Contact.Sms = person.Contact.Phones[3];
                person.Contact.Phones.RemoveAt(3);
            }

            return Put<CustomerPerson>(new ExecuteParams($"/customers/persons/{personId}", person));
        }

        public Task<XtrfResult<PersonContact>> UpdatePersonContact(long personId, PersonContact contact)
            => Put<PersonContact>(new ExecuteParams($"/customers/persons/{personId}/contact", contact));

        public Task<XtrfResult<CustomFields>> UpdatePersonCustomFields(long personId, CustomFields fields)
            => Put<CustomFields>(new ExecuteParams($"/customers/persons/{personId}/customFields", fields));

        public Task<XtrfResult<Customer>> UpdateCustomer(long customerId, Customer customer)
        {
            if ((customer?.Contact?.Phones?.Count ?? 0) > 3)
            {
                customer.Contact.Sms = customer.Contact.Phones[3];
                customer.Contact.Phones.RemoveAt(3);
            }
            return Put<Customer>(new ExecuteParams($"/customers/{customerId}", customer));
        }

        public Task<XtrfResult<Address>> UpdateCustomerAddress(long customerId, Address address)
            => Put<Address>(new ExecuteParams($"/customers/{customerId}/address", address));

        public Task<XtrfResult<Categories>> UpdateCustomerCategory(long customerId, Categories categories)
            => Put<Categories>(new ExecuteParams($"/customers/{customerId}/categories", categories));

        public Task<XtrfResult<Contact>> UpdateCustomerContact(long customerId, Contact contact)
            => Put<Contact>(new ExecuteParams($"/customers/{customerId}/contact", contact));

        public Task<XtrfResult<Address>> UpdateCorrespondenceAddress(long customerId, Address address)
            => Put<Address>(new ExecuteParams($"/customers/{customerId}/correspondenceAddress", address));

        public Task<XtrfResult<CustomFields>> UpdateCustomFields(long customerId, CustomFields customFields)
            => Put<CustomFields>(new ExecuteParams($"/customers/{customerId}/customFields", customFields));

        public Task<XtrfResult<CustomField>> UpdateSingleCustomField(long customerId, string customFieldKey, CustomField field)
            => Put<CustomField>(new ExecuteParams($"/customers/{customerId}/customFields/{customFieldKey}", field));

        public Task<XtrfResult<Industries>> UpdateIndustries(long customerId, Industries industries)
            => Put<Industries>(new ExecuteParams($"/customers/{customerId}/industries", industries));


        public Task<XtrfResult<Customer>> UpateProjectManager(long customerId, long projectManagerId)
        {
            var c = new Customer()
            {
                Id = customerId,
                ResponsiblePersons = new CustomerResponsiblePersons() { ProjectManagerId = projectManagerId }
            };
            return UpdateCustomer(customerId, c);
        }
        #endregion

        #region DELETE
        public Task<XtrfResult<Customer>> DeleteCustomer(long customerId)
            => Delete<Customer>(new ExecuteParams($"/customers/{customerId}"));

        #endregion
    }
}
