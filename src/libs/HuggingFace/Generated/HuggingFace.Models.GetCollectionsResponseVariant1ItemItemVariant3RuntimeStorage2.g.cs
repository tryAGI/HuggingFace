
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2
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
    public static class GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Large => "large",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Medium => "medium",
                GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "large" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Large,
                "medium" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Medium,
                "small" => GetCollectionsResponseVariant1ItemItemVariant3RuntimeStorage2.Small,
                _ => null,
            };
        }
    }
}