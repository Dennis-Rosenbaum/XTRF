using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Project
    {
        [JsonProperty("budgetCode")]
        public string BudgetCode { get; set; }
        [JsonProperty("categoryIds")]
        public List<object> CategoryIds { get; set; }
        [JsonProperty("clientDeadline")]
        public long? ClientDeadline { get; set; }
        [JsonProperty("clientId")]
        public long? ClientId { get; set; }
        [JsonProperty("clientNotes")]
        public string ClientNotes { get; set; }
        [JsonProperty("clientReferenceNumber")]
        public string ClientReferenceNumber { get; set; }
        [JsonProperty("documents")]
        public Documents Documents { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("instructionsForAllJobs")]
        public string InstructionsForAllJobs { get; set; }
        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }
        [JsonProperty("languages")]
        public ProjectLanguages Languages { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("orderedOn")]
        public long? OrderedOn { get; set; }
        [JsonProperty("origin")]
        public string Origin { get; set; }
        [JsonProperty("people")]
        public People People { get; set; }

        #region Classic Project or Classic Quote
        [JsonProperty("isClassicProject")]
        public bool? IsClassicProject { get; set; }
        [JsonProperty("isClassicQuote")]
        public bool? IsClassicQuote { get; set; }
        #endregion

        #region Project ID or Quote ID
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }
        #endregion

        [JsonProperty("projectIdNumber")]
        public string ProjectIdNumber { get; set; }
        [JsonProperty("quoteIdNumber")]
        public string QuoteIdNumber { get; set; }
        [JsonProperty("serviceId")]
        public long? ServiceId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("volume")]
        public Volume Volume { get; set; }

        public string GetId() => string.IsNullOrEmpty(ProjectId) ? QuoteId : ProjectId;
        public bool? IsClassic() => IsClassicProject.HasValue ? IsClassicProject : IsClassicQuote;

    }
}
