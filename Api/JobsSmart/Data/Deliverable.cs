using System.Collections.Generic;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Deliverable
    {
        public string id { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public long lastModifiedOn { get; set; }
        public bool isRemote { get; set; }
        public bool isAccepted { get; set; }
        public string categoryKey { get; set; }
        public DeliverableLanguageRelation languageRelation { get; set; }
        public DeliverableAddedBy addedBy { get; set; }
        public int addedInStep { get; set; }
        public string addedInJob { get; set; }
        public bool addedInLastStep { get; set; }
        public List<string> sharedWithJobs { get; set; }
        public RemoteCatToolReferences remoteCATToolReferences { get; set; }
    }
}
