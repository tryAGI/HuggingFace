
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseGatingVariant3NotificationsMode
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
    public static class CreateCollectionsItemsResponseGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseGatingVariant3NotificationsMode.Bulk => "bulk",
                CreateCollectionsItemsResponseGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => CreateCollectionsItemsResponseGatingVariant3NotificationsMode.Bulk,
                "real-time" => CreateCollectionsItemsResponseGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}