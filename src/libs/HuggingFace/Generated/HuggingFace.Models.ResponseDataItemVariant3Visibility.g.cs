
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3Visibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDataItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3Visibility value)
        {
            return value switch
            {
                ResponseDataItemVariant3Visibility.Public => "public",
                ResponseDataItemVariant3Visibility.Private => "private",
                ResponseDataItemVariant3Visibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseDataItemVariant3Visibility.Public,
                "private" => ResponseDataItemVariant3Visibility.Private,
                "protected" => ResponseDataItemVariant3Visibility.Protected,
                _ => null,
            };
        }
    }
}