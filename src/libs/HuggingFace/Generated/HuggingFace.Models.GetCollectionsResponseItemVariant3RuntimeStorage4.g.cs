
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeStorage4
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseItemVariant3RuntimeStorage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeStorage4 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeStorage4.Large => "large",
                GetCollectionsResponseItemVariant3RuntimeStorage4.Medium => "medium",
                GetCollectionsResponseItemVariant3RuntimeStorage4.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeStorage4? ToEnum(string value)
        {
            return value switch
            {
                "large" => GetCollectionsResponseItemVariant3RuntimeStorage4.Large,
                "medium" => GetCollectionsResponseItemVariant3RuntimeStorage4.Medium,
                "small" => GetCollectionsResponseItemVariant3RuntimeStorage4.Small,
                _ => null,
            };
        }
    }
}