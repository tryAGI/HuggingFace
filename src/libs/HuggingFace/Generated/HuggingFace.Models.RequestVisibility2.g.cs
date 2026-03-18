
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestVisibility2
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
    public static class RequestVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVisibility2 value)
        {
            return value switch
            {
                RequestVisibility2.Private => "private",
                RequestVisibility2.Public => "public",
                RequestVisibility2.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => RequestVisibility2.Private,
                "public" => RequestVisibility2.Public,
                "protected" => RequestVisibility2.Protected,
                _ => null,
            };
        }
    }
}