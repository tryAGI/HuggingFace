
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum RequestVisibility3
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
    public static class RequestVisibility3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVisibility3 value)
        {
            return value switch
            {
                RequestVisibility3.Private => "private",
                RequestVisibility3.Public => "public",
                RequestVisibility3.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVisibility3? ToEnum(string value)
        {
            return value switch
            {
                "private" => RequestVisibility3.Private,
                "public" => RequestVisibility3.Public,
                "protected" => RequestVisibility3.Protected,
                _ => null,
            };
        }
    }
}