
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatingVariant3NotificationsMode
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
    public static class RequestGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                RequestGatingVariant3NotificationsMode.Bulk => "bulk",
                RequestGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => RequestGatingVariant3NotificationsMode.Bulk,
                "real-time" => RequestGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}