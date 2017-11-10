using Newtonsoft.Json;
using BigDecimal = System.Nullable<long>;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Volume
    {
        [JsonProperty("unitId")]
        public long? UnitId { get; set; }
        [JsonProperty("value")]
        public BigDecimal Value { get; set; }
    }
}
