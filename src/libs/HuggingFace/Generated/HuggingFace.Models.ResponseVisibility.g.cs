
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum ResponseVisibility
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
    public static class ResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVisibility value)
        {
            return value switch
            {
                ResponseVisibility.Private => "private",
                ResponseVisibility.Public => "public",
                ResponseVisibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ResponseVisibility.Private,
                "public" => ResponseVisibility.Public,
                "protected" => ResponseVisibility.Protected,
                _ => null,
            };
        }
    }
}