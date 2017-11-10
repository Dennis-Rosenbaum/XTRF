using Newtonsoft.Json;
using BigDecimal = System.Nullable<long>;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Finance
    {
        [JsonProperty("currencyId")]
        public BigDecimal	CurrencyId { get; set; }
        [JsonProperty("totalAgreed")]
        public BigDecimal TotalAgreed { get; set; }
        [JsonProperty("totalCost")]
        public long? TotalCost { get; set; }
    }
}
