
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedNotificationsMode2
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
    public static class ResponseGatedNotificationsMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedNotificationsMode2 value)
        {
            return value switch
            {
                ResponseGatedNotificationsMode2.Bulk => "bulk",
                ResponseGatedNotificationsMode2.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedNotificationsMode2? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatedNotificationsMode2.Bulk,
                "real-time" => ResponseGatedNotificationsMode2.RealTime,
                _ => null,
            };
        }
    }
}