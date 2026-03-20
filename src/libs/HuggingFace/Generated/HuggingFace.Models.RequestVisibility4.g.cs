
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestVisibility4
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
    public static class RequestVisibility4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVisibility4 value)
        {
            return value switch
            {
                RequestVisibility4.Private => "private",
                RequestVisibility4.Public => "public",
                RequestVisibility4.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVisibility4? ToEnum(string value)
        {
            return value switch
            {
                "private" => RequestVisibility4.Private,
                "public" => RequestVisibility4.Public,
                "protected" => RequestVisibility4.Protected,
                _ => null,
            };
        }
    }
}