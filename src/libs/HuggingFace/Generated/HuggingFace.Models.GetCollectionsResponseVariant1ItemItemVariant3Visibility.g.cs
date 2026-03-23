
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3Visibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsResponseVariant1ItemItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3Visibility value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3Visibility.Private => "private",
                GetCollectionsResponseVariant1ItemItemVariant3Visibility.Protected => "protected",
                GetCollectionsResponseVariant1ItemItemVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetCollectionsResponseVariant1ItemItemVariant3Visibility.Private,
                "protected" => GetCollectionsResponseVariant1ItemItemVariant3Visibility.Protected,
                "public" => GetCollectionsResponseVariant1ItemItemVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}