
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsResponseGatedNotificationsMode
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
    public static class PutDatasetsSettingsResponseGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsResponseGatedNotificationsMode value)
        {
            return value switch
            {
                PutDatasetsSettingsResponseGatedNotificationsMode.Bulk => "bulk",
                PutDatasetsSettingsResponseGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsResponseGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutDatasetsSettingsResponseGatedNotificationsMode.Bulk,
                "real-time" => PutDatasetsSettingsResponseGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}