using Newtonsoft.Json;

namespace Xtrf.Api.Dictionaries.Data
{
    public class LeadSource : DictionaryDataBase
    {
        [JsonProperty("availableForCustomer")]
        public bool? AvailableForCustomer { get; set; }

        [JsonProperty("availableForProvider")]
        public bool? AvailableForProvider { get; set; }
    }
}
