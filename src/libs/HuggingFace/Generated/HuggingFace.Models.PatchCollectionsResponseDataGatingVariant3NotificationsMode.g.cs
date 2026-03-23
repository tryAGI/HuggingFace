
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataGatingVariant3NotificationsMode
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
    public static class PatchCollectionsResponseDataGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                PatchCollectionsResponseDataGatingVariant3NotificationsMode.Bulk => "bulk",
                PatchCollectionsResponseDataGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => PatchCollectionsResponseDataGatingVariant3NotificationsMode.Bulk,
                "real-time" => PatchCollectionsResponseDataGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}