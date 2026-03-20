
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedNotificationsMode3
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
    public static class ResponseGatedNotificationsMode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedNotificationsMode3 value)
        {
            return value switch
            {
                ResponseGatedNotificationsMode3.Bulk => "bulk",
                ResponseGatedNotificationsMode3.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedNotificationsMode3? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatedNotificationsMode3.Bulk,
                "real-time" => ResponseGatedNotificationsMode3.RealTime,
                _ => null,
            };
        }
    }
}