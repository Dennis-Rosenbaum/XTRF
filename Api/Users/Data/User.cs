using Newtonsoft.Json;

namespace Xtrf.Api.Users.Data
{
    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
