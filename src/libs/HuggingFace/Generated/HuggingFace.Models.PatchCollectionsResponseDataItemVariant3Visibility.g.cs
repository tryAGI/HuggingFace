
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3Visibility
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
    public static class PatchCollectionsResponseDataItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3Visibility value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3Visibility.Private => "private",
                PatchCollectionsResponseDataItemVariant3Visibility.Protected => "protected",
                PatchCollectionsResponseDataItemVariant3Visibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchCollectionsResponseDataItemVariant3Visibility.Private,
                "protected" => PatchCollectionsResponseDataItemVariant3Visibility.Protected,
                "public" => PatchCollectionsResponseDataItemVariant3Visibility.Public,
                _ => null,
            };
        }
    }
}