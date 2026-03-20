
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum ResponseVisibility2
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Protected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVisibility2 value)
        {
            return value switch
            {
                ResponseVisibility2.Private => "private",
                ResponseVisibility2.Public => "public",
                ResponseVisibility2.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => ResponseVisibility2.Private,
                "public" => ResponseVisibility2.Public,
                "protected" => ResponseVisibility2.Protected,
                _ => null,
            };
        }
    }
}