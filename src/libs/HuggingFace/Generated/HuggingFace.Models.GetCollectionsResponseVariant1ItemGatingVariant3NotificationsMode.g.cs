
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode
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
    public static class GetCollectionsResponseVariant1ItemGatingVariant3NotificationsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode.Bulk => "bulk",
                GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode.RealTime => "real-time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode? ToEnum(string value)
        {
            return value switch
            {
                "bulk" => GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode.Bulk,
                "real-time" => GetCollectionsResponseVariant1ItemGatingVariant3NotificationsMode.RealTime,
                _ => null,
            };
        }
    }
}