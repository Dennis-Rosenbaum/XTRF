using Newtonsoft.Json;
using Xtrf.Common.Extention;

namespace Xtrf.Api.Subscription.Data
{
    public class SubscriptionCreate
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("event")]
        public string Event { get; set; }

        public SubscriptionCreate() { }
        public SubscriptionCreate(SubscriptionEvents eventName, string url)
        {
            Event = eventName.GetName();
            Url = url;
        }
    }
}
