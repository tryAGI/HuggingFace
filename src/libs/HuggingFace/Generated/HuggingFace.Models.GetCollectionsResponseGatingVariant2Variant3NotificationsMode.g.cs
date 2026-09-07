
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseGatingVariant2Variant3NotificationsMode
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
    public static class GetCollectionsResponseGatingVariant2Variant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseGatingVariant2Variant3NotificationsMode value)
        {
            return value switch
            {
                GetCollectionsResponseGatingVariant2Variant3NotificationsMode.Bulk => "bulk",
                GetCollectionsResponseGatingVariant2Variant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseGatingVariant2Variant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => GetCollectionsResponseGatingVariant2Variant3NotificationsMode.Bulk,
                "real-time" => GetCollectionsResponseGatingVariant2Variant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}