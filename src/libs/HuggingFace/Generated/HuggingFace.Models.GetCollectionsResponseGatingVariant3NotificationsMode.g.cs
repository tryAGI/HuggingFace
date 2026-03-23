
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseGatingVariant3NotificationsMode
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
    public static class GetCollectionsResponseGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                GetCollectionsResponseGatingVariant3NotificationsMode.Bulk => "bulk",
                GetCollectionsResponseGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => GetCollectionsResponseGatingVariant3NotificationsMode.Bulk,
                "real-time" => GetCollectionsResponseGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}