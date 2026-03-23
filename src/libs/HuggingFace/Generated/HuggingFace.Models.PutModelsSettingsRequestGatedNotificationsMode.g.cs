
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsRequestGatedNotificationsMode
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
    public static class PutModelsSettingsRequestGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsRequestGatedNotificationsMode value)
        {
            return value switch
            {
                PutModelsSettingsRequestGatedNotificationsMode.Bulk => "bulk",
                PutModelsSettingsRequestGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsRequestGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutModelsSettingsRequestGatedNotificationsMode.Bulk,
                "real-time" => PutModelsSettingsRequestGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}