
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatingVariant3NotificationsMode2
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
    public static class ResponseGatingVariant3NotificationsMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatingVariant3NotificationsMode2 value)
        {
            return value switch
            {
                ResponseGatingVariant3NotificationsMode2.Bulk => "bulk",
                ResponseGatingVariant3NotificationsMode2.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatingVariant3NotificationsMode2? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatingVariant3NotificationsMode2.Bulk,
                "real-time" => ResponseGatingVariant3NotificationsMode2.RealTime,
                _ => null,
            };
        }
    }
}