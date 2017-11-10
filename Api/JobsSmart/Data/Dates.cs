using Newtonsoft.Json;
using System;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Dates
    {
        [JsonProperty("startDate")]
        public long? StartDate { get; set; }
        [JsonProperty("actualStartDate")]
        public long? ActualStartDate { get; set; }
        [JsonProperty("actualEndDate")]
        public long? ActualEndDate { get; set; }

        public Dates() { }
        public Dates(DateTime startDate, DateTime actualStartDate, DateTime actualEndDate)
        {
            StartDate = Helper.UnixTimeHelper.UnixTimeLong(startDate);
            ActualStartDate = Helper.UnixTimeHelper.UnixTimeLong(actualStartDate);
            ActualEndDate = Helper.UnixTimeHelper.UnixTimeLong(actualEndDate);
        }
    }
}
