
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsResponseGatedNotificationsMode
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
    public static class PutSpacesSettingsResponseGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsResponseGatedNotificationsMode value)
        {
            return value switch
            {
                PutSpacesSettingsResponseGatedNotificationsMode.Bulk => "bulk",
                PutSpacesSettingsResponseGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsResponseGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutSpacesSettingsResponseGatedNotificationsMode.Bulk,
                "real-time" => PutSpacesSettingsResponseGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}