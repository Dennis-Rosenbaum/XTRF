using Newtonsoft.Json;

namespace Xtrf.Api.Dictionaries.Data
{
    public class Province : DictionaryDataBase
    {
        [JsonProperty("countryId")]
        public long? CountryId { get; set; }
    }
}
