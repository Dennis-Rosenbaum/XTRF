using Newtonsoft.Json;

namespace Xtrf.Api.Customers.Data
{
    public class AccessToken
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
