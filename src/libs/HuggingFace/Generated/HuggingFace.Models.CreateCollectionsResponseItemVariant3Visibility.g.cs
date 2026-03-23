
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3Visibility
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
    public static class CreateCollectionsResponseItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3Visibility value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3Visibility.Private => "private",
                CreateCollectionsResponseItemVariant3Visibility.Protected => "protected",
                CreateCollectionsResponseItemVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateCollectionsResponseItemVariant3Visibility.Private,
                "protected" => CreateCollectionsResponseItemVariant3Visibility.Protected,
                "public" => CreateCollectionsResponseItemVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}