
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatedNotificationsMode2
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
    public static class RequestGatedNotificationsMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatedNotificationsMode2 value)
        {
            return value switch
            {
                RequestGatedNotificationsMode2.Bulk => "bulk",
                RequestGatedNotificationsMode2.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatedNotificationsMode2? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => RequestGatedNotificationsMode2.Bulk,
                "real-time" => RequestGatedNotificationsMode2.RealTime,
                _ => null,
            };
        }
    }
}