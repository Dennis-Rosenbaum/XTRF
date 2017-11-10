using Newtonsoft.Json;

namespace Xtrf.Api.Dictionaries.Data
{
    public class Country : DictionaryDataBase
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
