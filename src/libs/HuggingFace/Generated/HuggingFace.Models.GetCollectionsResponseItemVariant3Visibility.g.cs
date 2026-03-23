
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3Visibility
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
    public static class GetCollectionsResponseItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3Visibility value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3Visibility.Private => "private",
                GetCollectionsResponseItemVariant3Visibility.Protected => "protected",
                GetCollectionsResponseItemVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetCollectionsResponseItemVariant3Visibility.Private,
                "protected" => GetCollectionsResponseItemVariant3Visibility.Protected,
                "public" => GetCollectionsResponseItemVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}