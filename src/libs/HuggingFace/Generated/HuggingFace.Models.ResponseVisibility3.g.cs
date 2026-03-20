
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum ResponseVisibility3
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
    public static class ResponseVisibility3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVisibility3 value)
        {
            return value switch
            {
                ResponseVisibility3.Private => "private",
                ResponseVisibility3.Public => "public",
                ResponseVisibility3.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVisibility3? ToEnum(string value)
        {
            return value switch
            {
                "private" => ResponseVisibility3.Private,
                "public" => ResponseVisibility3.Public,
                "protected" => ResponseVisibility3.Protected,
                _ => null,
            };
        }
    }
}