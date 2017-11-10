using Newtonsoft.Json;

namespace Xtrf.Api.Subscription.Data
{
    public class Subscription
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("event")]
        public string Event { get; set; }
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
        [JsonProperty("filter")]
        public string Filter { get; set; }
        [JsonProperty("embed")]
        public string Embed { get; set; }
    }
}
