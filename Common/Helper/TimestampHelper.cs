using System;

namespace One.Common
{
    /// <summary>
    /// Summary description for TimestampHelper
    /// </summary>
    public static class TimestampHelper
    {
        public static long ToUnixTime(this DateTime datetime)
        {
            return (long)datetime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }

        public static long? ToUnixTime(this DateTime? datetime)
        {
            if (!datetime.HasValue)
            {
                return null;
            }

            return datetime.Value.ToUnixTime(); ;
        }

        public static DateTime FromUnixTime(long span)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(span).ToLocalTime();
        }

        public static DateTime? FromUnixTime(long? span)
        {
            DateTime? result = span.HasValue ? (DateTime?)new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(span.Value).ToLocalTime() : null;
            return result;
        }

        public static long ToTimestamp(this DateTime datetime)
        {
            return (long)datetime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        public static long? ToTimestamp(this DateTime? datetime)
        {
            if (!datetime.HasValue)
            {
                return null;
            }

            return datetime.Value.ToTimestamp();
        }
    }
}