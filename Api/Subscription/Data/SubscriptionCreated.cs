using Newtonsoft.Json;

namespace Xtrf.Api.Subscription.Data
{
    public class SubscriptionCreated
    {
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }
        [JsonProperty("status")]
        public string StatusCode { get; set; }
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty("detailedMessage")]
        public string DetailedErrorMessage { get; set; }

    }
}
