
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatedNotificationsMode
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
    public static class RequestGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatedNotificationsMode value)
        {
            return value switch
            {
                RequestGatedNotificationsMode.Bulk => "bulk",
                RequestGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => RequestGatedNotificationsMode.Bulk,
                "real-time" => RequestGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}