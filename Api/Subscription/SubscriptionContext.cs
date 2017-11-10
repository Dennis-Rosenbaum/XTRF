using System.Threading.Tasks;
using Xtrf.Api.Base;

namespace Xtrf.Api.Subscription
{
    public class SubscriptionContext : ContextBase
    {
        internal SubscriptionContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        public Task<XtrfResult<Data.SubscriptionCreated>> CreateNew(Data.SubscriptionCreate newSubscription)
            => Post<Data.SubscriptionCreated>(new ExecuteParams("/subscription", newSubscription));
        #endregion

        #region GET
        public Task<XtrfResult<Data.Subscriptions>> Get()
            => Get<Data.Subscriptions>(new ExecuteParams($"/subscription"));
        #endregion

        #region DELETE
        public Task DeleteSubscription(string subscriptionId)
            => Delete(new ExecuteParams($"/subscription/{subscriptionId}"));
        #endregion

    }
}
