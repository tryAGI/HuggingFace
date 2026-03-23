
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsResponseGatedNotificationsMode
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
    public static class PutModelsSettingsResponseGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsResponseGatedNotificationsMode value)
        {
            return value switch
            {
                PutModelsSettingsResponseGatedNotificationsMode.Bulk => "bulk",
                PutModelsSettingsResponseGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsResponseGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutModelsSettingsResponseGatedNotificationsMode.Bulk,
                "real-time" => PutModelsSettingsResponseGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}