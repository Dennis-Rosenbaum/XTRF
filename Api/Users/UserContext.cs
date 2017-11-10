using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Users.Data;
using Xtrf.Core.Data;

namespace Xtrf.Api.Users
{
    public class UserContext : ContextBase
    {
        internal UserContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }
        
        #region GET
        public Task<XtrfResult<EntityWithNames>> GetAll()
            => Get<EntityWithNames>(new ExecuteParams($"/users/"));
        
        public Task<XtrfResult<User>> GetActive(long userId)
            => Get<User>(new ExecuteParams($"/users/{userId}"));
        #endregion

    }
}
