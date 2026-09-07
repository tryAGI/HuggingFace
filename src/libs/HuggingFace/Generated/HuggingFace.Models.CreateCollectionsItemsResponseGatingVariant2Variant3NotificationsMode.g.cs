
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode
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
    public static class CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode.Bulk => "bulk",
                CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode.Bulk,
                "real-time" => CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}