using Newtonsoft.Json;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ProjectFileAddedBy
    {
        [JsonProperty("userType")]
        public string UserType { get; set; }
        [JsonProperty("vendorId")]
        public long? VendorId { get; set; }
    }
}
