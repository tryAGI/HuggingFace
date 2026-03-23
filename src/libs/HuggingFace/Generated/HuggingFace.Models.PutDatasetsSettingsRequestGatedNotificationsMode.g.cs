
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsRequestGatedNotificationsMode
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
    public static class PutDatasetsSettingsRequestGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsRequestGatedNotificationsMode value)
        {
            return value switch
            {
                PutDatasetsSettingsRequestGatedNotificationsMode.Bulk => "bulk",
                PutDatasetsSettingsRequestGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsRequestGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutDatasetsSettingsRequestGatedNotificationsMode.Bulk,
                "real-time" => PutDatasetsSettingsRequestGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}