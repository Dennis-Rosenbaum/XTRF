using Xtrf.Common.Attribute;

namespace Xtrf.Api.Subscription.Data
{
    public enum SubscriptionEvents
    {
        [EnumName("project_created")]
        ProjectCreated,
        [EnumName("quote_created")]
        QuoteCreated,
        [EnumName("job_status_changed")]
        JobStatusChanged,
        [EnumName("customer_created")]
        CustomerCreated,
        [EnumName("customer_updated")]
        CustomerUpdated
    }
}
