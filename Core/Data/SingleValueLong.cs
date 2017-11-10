using Newtonsoft.Json;
using System.Collections.Generic;
using BigDecimal = System.Nullable<long>;

namespace Xtrf.Core.Data
{
    public class SingleValueLong
    {
        [JsonProperty("value")]
        public BigDecimal Value { get; set; }

        public SingleValueLong() { }
        public SingleValueLong(BigDecimal value)
        {
            Value = value;
        }
    }
}
