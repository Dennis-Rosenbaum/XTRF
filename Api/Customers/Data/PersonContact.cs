using Newtonsoft.Json;
using Xtrf.Core.Data;
using System.Collections.Generic;

namespace Xtrf.Api.Customers.Data
{
    public class PersonContact
    {
        [JsonProperty("emails")]
        public CustomerContactEmails Emails { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }
        [JsonProperty("phones")]
        public List<string> Phones { get; set; }
        [JsonProperty("sms")]
        public string Sms { get; set; }
    }
}
