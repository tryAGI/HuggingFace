
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Visibility
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
    public static class ResponseItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Visibility value)
        {
            return value switch
            {
                ResponseItemVariant3Visibility.Public => "public",
                ResponseItemVariant3Visibility.Private => "private",
                ResponseItemVariant3Visibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseItemVariant3Visibility.Public,
                "private" => ResponseItemVariant3Visibility.Private,
                "protected" => ResponseItemVariant3Visibility.Protected,
                _ => null,
            };
        }
    }
}