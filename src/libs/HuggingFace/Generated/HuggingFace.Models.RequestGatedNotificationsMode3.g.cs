
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatedNotificationsMode3
    {
        /// <summary>
        /// 
        /// </summary>
        Bulk,
        /// <summary>
        /// 
        /// </summary>
        RealTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGatedNotificationsMode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatedNotificationsMode3 value)
        {
            return value switch
            {
                RequestGatedNotificationsMode3.Bulk => "bulk",
                RequestGatedNotificationsMode3.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatedNotificationsMode3? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => RequestGatedNotificationsMode3.Bulk,
                "real-time" => RequestGatedNotificationsMode3.RealTime,
                _ => null,
            };
        }
    }
}