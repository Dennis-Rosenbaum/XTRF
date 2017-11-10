using System.Collections.Generic;
using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Vendors.Params;
using Xtrf.Core.Data;
using Xtrf.Core.Params;

namespace Xtrf.Api.Vendors
{
    public class VendorContext : ContextBase
    {
        internal VendorContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }
        
        #region GET
        public Task<XtrfResult<List<int>>> GetAllIds(UpdatedSinceParameter param = null)
            => Get<List<int>>(new ExecuteParams($"/providers/ids", param));
        
        public Task<XtrfResult<Data.Provider>> GetSingle(long providerId, GetSingleParameter param = null)
            => Get<Data.Provider>(new ExecuteParams($"/providers/{providerId}", param));

        public Task<XtrfResult<Address>> GetAddress(long providerId)
            => Get<Address>(new ExecuteParams($"/providers/{providerId}/address"));

        public Task<XtrfResult<Data.Competencies>> GetCompetencies(long providerId)
            => Get<Data.Competencies>(new ExecuteParams($"/providers/{providerId}/competencies"));

        public Task<XtrfResult<Address>> GetCorrespondenceAddress(long providerId)
            => Get<Address>(new ExecuteParams($"/providers/{providerId}/correspondenceAddress"));

        public Task<XtrfResult<CustomFields>> GetCustomFields(long providerId)
            => Get<CustomFields>(new ExecuteParams($"/providers/{providerId}/customFields"));

        public Task<XtrfResult<Contact>> GetContact(long providerId)
            => Get<Contact>(new ExecuteParams($"/providers/{providerId}/contact"));
        #endregion

    }
}
