
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseGatingVariant3NotificationsMode
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
    public static class CreateCollectionsResponseGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                CreateCollectionsResponseGatingVariant3NotificationsMode.Bulk => "bulk",
                CreateCollectionsResponseGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => CreateCollectionsResponseGatingVariant3NotificationsMode.Bulk,
                "real-time" => CreateCollectionsResponseGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}