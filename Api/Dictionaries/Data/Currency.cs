using Newtonsoft.Json;

namespace Xtrf.Api.Dictionaries.Data
{
    public class Currency : DictionaryDataBase
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// ISO 4217 code: https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }
}
