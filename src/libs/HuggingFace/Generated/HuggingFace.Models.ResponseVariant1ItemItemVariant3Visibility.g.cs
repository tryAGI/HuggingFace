
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3Visibility
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
    public static class ResponseVariant1ItemItemVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3Visibility value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3Visibility.Public => "public",
                ResponseVariant1ItemItemVariant3Visibility.Private => "private",
                ResponseVariant1ItemItemVariant3Visibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseVariant1ItemItemVariant3Visibility.Public,
                "private" => ResponseVariant1ItemItemVariant3Visibility.Private,
                "protected" => ResponseVariant1ItemItemVariant3Visibility.Protected,
                _ => null,
            };
        }
    }
}