
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedNotificationsMode
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
    public static class ResponseGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedNotificationsMode value)
        {
            return value switch
            {
                ResponseGatedNotificationsMode.Bulk => "bulk",
                ResponseGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => ResponseGatedNotificationsMode.Bulk,
                "real-time" => ResponseGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}