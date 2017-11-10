using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Job
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("stepNumber")]
        public int? StepNumber { get; set; }
        [JsonProperty("stepType")]
        public StepType StepType { get; set; }
        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }
        [JsonProperty("vendorId")]
        public int? VendorId { get; set; }
        [JsonProperty("vendorPriceProfileId")]
        public int? VendorPriceProfileId { get; set; }
        [JsonProperty("dates")]
        public Dates Dates { get; set; }
        [JsonProperty("files")]
        public Files Files { get; set; }
        [JsonProperty("communication")]
        public Communication Communication { get; set; }
        [JsonProperty("documents")]
        public Documents Documents { get; set; }
    }
}
