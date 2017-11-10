using Newtonsoft.Json;

namespace Xtrf.Core.Data
{
    public class SingleValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        public SingleValue() { }
        public SingleValue(string value)
        {
            Value = value;
        }
    }
}
