using Newtonsoft.Json;
using System;

namespace Xtrf.Api.ProjectsSmart.Data
{
    public class Time
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        public Time() { }
        public Time(DateTime date)
        {
            Value = Helper.UnixTimeHelper.UnixTimeLong(date);
        }
    }
}
