using Newtonsoft.Json;
using Xtrf.Core.Data;
using System.Collections.Generic;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class MultiPart
    {
        [JsonProperty("bodyParts")]
        public List<BodyPart> BodyParts { get; set; }
        [JsonProperty("contentDisposition")]
        public ContentDisposition ContentDisposition { get; set; }
        [JsonProperty("entity")]
        public object Entity { get; set; }
        [JsonProperty("headers")]
        public Dictionary<string, List<string>> Headers { get; set; }
        [JsonProperty("mediaType")]
        public MediaType MediaType { get; set; }

        //Is in the documentation, but cannot find the definition of a messagebodyworker in the javadoc
        //[JsonProperty("messageBodyWorkers")]
        //public MessageBodyWorkers MessageBodyWorkers { get; set; }
        [JsonProperty("parameterizedHeaders")]
        public Dictionary<string, List<ParameterizedHeader>> ParameterizedHeaders { get; set; }
        [JsonProperty("parent")]
        public MultiPart Parent { get; set; }
        [JsonProperty("providers")]
        public Providers Providers { get; set; }
    }
}
