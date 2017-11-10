using Newtonsoft.Json;

namespace Xtrf.Api.CustomerInvoices.Data
{
    public class SendRemindersResponse
    {
        [JsonProperty("numberOfSentEmails")]
        public int? NumberOfSentEmails { get; set; }
    }
}
