
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsRequestGatingVariant3NotificationsMode
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
    public static class PatchCollectionsRequestGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsRequestGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                PatchCollectionsRequestGatingVariant3NotificationsMode.Bulk => "bulk",
                PatchCollectionsRequestGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsRequestGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PatchCollectionsRequestGatingVariant3NotificationsMode.Bulk,
                "real-time" => PatchCollectionsRequestGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}