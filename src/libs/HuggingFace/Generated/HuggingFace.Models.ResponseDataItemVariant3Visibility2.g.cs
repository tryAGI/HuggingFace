
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3Visibility2
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
    public static class ResponseDataItemVariant3Visibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3Visibility2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3Visibility2.Public => "public",
                ResponseDataItemVariant3Visibility2.Private => "private",
                ResponseDataItemVariant3Visibility2.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3Visibility2? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseDataItemVariant3Visibility2.Public,
                "private" => ResponseDataItemVariant3Visibility2.Private,
                "protected" => ResponseDataItemVariant3Visibility2.Protected,
                _ => null,
            };
        }
    }
}