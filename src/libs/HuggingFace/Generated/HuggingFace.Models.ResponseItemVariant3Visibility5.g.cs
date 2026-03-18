
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3Visibility5
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
    public static class ResponseItemVariant3Visibility5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3Visibility5 value)
        {
            return value switch
            {
                ResponseItemVariant3Visibility5.Public => "public",
                ResponseItemVariant3Visibility5.Private => "private",
                ResponseItemVariant3Visibility5.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3Visibility5? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseItemVariant3Visibility5.Public,
                "private" => ResponseItemVariant3Visibility5.Private,
                "protected" => ResponseItemVariant3Visibility5.Protected,
                _ => null,
            };
        }
    }
}