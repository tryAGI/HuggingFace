
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseGatingVariant3NotificationsMode2
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
    public static class CreateCollectionsItemsResponseGatingVariant3NotificationsMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseGatingVariant3NotificationsMode2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseGatingVariant3NotificationsMode2.Bulk => "bulk",
                CreateCollectionsItemsResponseGatingVariant3NotificationsMode2.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseGatingVariant3NotificationsMode2? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => CreateCollectionsItemsResponseGatingVariant3NotificationsMode2.Bulk,
                "real-time" => CreateCollectionsItemsResponseGatingVariant3NotificationsMode2.RealTime,
                _ => null,
            };
        }
    }
}