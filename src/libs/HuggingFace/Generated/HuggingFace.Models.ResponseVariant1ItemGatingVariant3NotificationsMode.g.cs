
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemGatingVariant3NotificationsMode
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
    public static class ResponseVariant1ItemGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                ResponseVariant1ItemGatingVariant3NotificationsMode.Bulk => "bulk",
                ResponseVariant1ItemGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseVariant1ItemGatingVariant3NotificationsMode.Bulk,
                "real-time" => ResponseVariant1ItemGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}