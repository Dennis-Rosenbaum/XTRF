using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Services.Params;

namespace Xtrf.Api.Services
{
    public class ServicesContext : ContextBase
    {
        internal ServicesContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }
        
        #region GET
        public Task<XtrfResult<Data.Services>> GetAll(GetParameter param = null)
            => Get<Data.Services>(new ExecuteParams($"/services/active", param));
        
        public Task<XtrfResult<Data.Services>> GetActive(GetParameter param = null)
            => Get<Data.Services>(new ExecuteParams($"/services/all", param));
        #endregion

    }
}
