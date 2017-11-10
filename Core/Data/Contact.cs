using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class Contact
    {
        [JsonProperty("emails")]
        public CustomerContactEmails Emails { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }
        [JsonProperty("phones")]
        public List<string> Phones { get; set; }
        [JsonProperty("sms")]
        public string Sms { get; set; }
        [JsonProperty("websites")]
        public List<string> Websites { get; set; }
    }
}
