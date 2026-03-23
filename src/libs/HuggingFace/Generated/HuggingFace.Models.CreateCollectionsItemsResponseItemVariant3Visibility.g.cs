
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3Visibility
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
    public static class CreateCollectionsItemsResponseItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3Visibility value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3Visibility.Private => "private",
                CreateCollectionsItemsResponseItemVariant3Visibility.Protected => "protected",
                CreateCollectionsItemsResponseItemVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateCollectionsItemsResponseItemVariant3Visibility.Private,
                "protected" => CreateCollectionsItemsResponseItemVariant3Visibility.Protected,
                "public" => CreateCollectionsItemsResponseItemVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}