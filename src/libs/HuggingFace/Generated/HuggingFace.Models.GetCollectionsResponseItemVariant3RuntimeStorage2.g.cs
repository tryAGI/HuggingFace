
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3RuntimeStorage2
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
    public static class GetCollectionsResponseItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3RuntimeStorage2.Large => "large",
                GetCollectionsResponseItemVariant3RuntimeStorage2.Medium => "medium",
                GetCollectionsResponseItemVariant3RuntimeStorage2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "large" => GetCollectionsResponseItemVariant3RuntimeStorage2.Large,
                "medium" => GetCollectionsResponseItemVariant3RuntimeStorage2.Medium,
                "small" => GetCollectionsResponseItemVariant3RuntimeStorage2.Small,
                _ => null,
            };
        }
    }
}