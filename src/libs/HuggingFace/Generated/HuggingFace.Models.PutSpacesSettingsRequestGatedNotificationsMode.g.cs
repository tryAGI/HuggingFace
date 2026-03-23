
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsRequestGatedNotificationsMode
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
    public static class PutSpacesSettingsRequestGatedNotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsRequestGatedNotificationsMode value)
        {
            return value switch
            {
                PutSpacesSettingsRequestGatedNotificationsMode.Bulk => "bulk",
                PutSpacesSettingsRequestGatedNotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsRequestGatedNotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PutSpacesSettingsRequestGatedNotificationsMode.Bulk,
                "real-time" => PutSpacesSettingsRequestGatedNotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}