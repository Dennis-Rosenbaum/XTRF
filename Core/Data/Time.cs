using Newtonsoft.Json;
using System;

namespace Xtrf.Core.Data
{
    public class Time
    {
        [JsonProperty("time")]
        public long? TimeLong { get; set; }

        public DateTime? GetDateTime()
        {
            if (TimeLong.HasValue)
                return Helper.UnixTimeHelper.GetUnixTime(TimeLong.Value);
            return null;
        }
       
    }
}
