using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class ProjectFile
    {
        [JsonProperty("addedBy")]
        public ProjectFileAddedBy AddedBy { get; set; }
        [JsonProperty("addedInJob")]
        public string AddedInJob { get; set; }
        [JsonProperty("addedInLastStep")]
        public bool? AddedInLastStep { get; set; }
        [JsonProperty("addedInStep")]
        public long? AddedInStep { get; set; }
        [JsonProperty("categoryKey")]
        public string CategoryKey { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isAccepted")]
        public bool? IsAccepted { get; set; }
        [JsonProperty("isRemote")]
        public bool? IsRemote { get; set; }
        [JsonProperty("languageRelation")]
        public LanguageRelation LanguageRelation { get; set; }
        [JsonProperty("lastModifiedOn")]
        public long? LastModifiedOn { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("remoteCATToolReferences")]
        public RemoteCatToolReferences RemoteCatToolReferences { get; set; }
        [JsonProperty("sharedWithJobs")]
        public List<object> SharedWithJobs { get; set; }
        [JsonProperty("size")]
        public long? Size { get; set; }

        public bool IsCategory(string category) => CategoryKey == category;
    }
}
