
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3Visibility2
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
    public static class PatchCollectionsResponseDataItemVariant3Visibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3Visibility2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3Visibility2.Private => "private",
                PatchCollectionsResponseDataItemVariant3Visibility2.Protected => "protected",
                PatchCollectionsResponseDataItemVariant3Visibility2.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3Visibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => PatchCollectionsResponseDataItemVariant3Visibility2.Private,
                "protected" => PatchCollectionsResponseDataItemVariant3Visibility2.Protected,
                "public" => PatchCollectionsResponseDataItemVariant3Visibility2.Public,
                _ => null,
            };
        }
    }
}