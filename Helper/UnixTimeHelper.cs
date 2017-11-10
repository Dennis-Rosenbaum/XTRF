using System;

namespace Xtrf.Helper
{
    public class UnixTimeHelper
    {
        //public static double UnixTimeNow => (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
        public static long UnixTimeNowLong => UnixTimeLong(DateTime.UtcNow);

        internal static DateTime GetUnixTime(long theTime) => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(theTime).ToLocalTime();

        public static long UnixTimeLong(DateTime d) => Convert.ToInt64(Math.Floor((d - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds));
    }
}
