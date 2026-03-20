
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
    /// </summary>
    public enum RequestVisibility5
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
    public static class RequestVisibility5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVisibility5 value)
        {
            return value switch
            {
                RequestVisibility5.Private => "private",
                RequestVisibility5.Public => "public",
                RequestVisibility5.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVisibility5? ToEnum(string value)
        {
            return value switch
            {
                "private" => RequestVisibility5.Private,
                "public" => RequestVisibility5.Public,
                "protected" => RequestVisibility5.Protected,
                _ => null,
            };
        }
    }
}