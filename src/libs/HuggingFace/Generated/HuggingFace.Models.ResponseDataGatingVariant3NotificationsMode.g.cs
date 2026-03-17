
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataGatingVariant3NotificationsMode
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
    public static class ResponseDataGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                ResponseDataGatingVariant3NotificationsMode.Bulk => "bulk",
                ResponseDataGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseDataGatingVariant3NotificationsMode.Bulk,
                "real-time" => ResponseDataGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}