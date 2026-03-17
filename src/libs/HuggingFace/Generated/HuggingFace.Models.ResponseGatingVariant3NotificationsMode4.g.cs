
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatingVariant3NotificationsMode4
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
    public static class ResponseGatingVariant3NotificationsMode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatingVariant3NotificationsMode4 value)
        {
            return value switch
            {
                ResponseGatingVariant3NotificationsMode4.Bulk => "bulk",
                ResponseGatingVariant3NotificationsMode4.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatingVariant3NotificationsMode4? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatingVariant3NotificationsMode4.Bulk,
                "real-time" => ResponseGatingVariant3NotificationsMode4.RealTime,
                _ => null,
            };
        }
    }
}