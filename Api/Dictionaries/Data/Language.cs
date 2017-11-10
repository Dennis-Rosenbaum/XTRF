using Newtonsoft.Json;

namespace Xtrf.Api.Dictionaries.Data
{
    public class Language : DictionaryDataBase
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// ISO 6391 code: https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes
        /// </summary>
        [JsonProperty("iso6391")]
        public string Iso6391 { get; set; }

        /// <summary>
        /// ISO 6392 code: https://en.wikipedia.org/wiki/List_of_ISO_639-2_codes
        /// </summary>
        [JsonProperty("iso6392")]
        public string Iso6392 { get; set; }
    }
}
