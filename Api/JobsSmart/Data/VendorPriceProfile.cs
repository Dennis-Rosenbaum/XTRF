using Newtonsoft.Json;

namespace Xtrf.Api.JobsSmart.Data
{
    public class VendorPriceProfile
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        public VendorPriceProfile() { }
        public VendorPriceProfile(int value)
        {
            Value = value;
        }
    }
}
