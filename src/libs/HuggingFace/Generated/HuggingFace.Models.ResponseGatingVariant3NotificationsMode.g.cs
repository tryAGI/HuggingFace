
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatingVariant3NotificationsMode
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
    public static class ResponseGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                ResponseGatingVariant3NotificationsMode.Bulk => "bulk",
                ResponseGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatingVariant3NotificationsMode.Bulk,
                "real-time" => ResponseGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}