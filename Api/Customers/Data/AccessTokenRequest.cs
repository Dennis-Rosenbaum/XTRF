using Newtonsoft.Json;

namespace Xtrf.Api.Customers.Data
{
    public class AccessTokenRequest
    {
        [JsonProperty("loginOrEmail")]
        public string LoginOrEmail { get; set; }
    }
}
