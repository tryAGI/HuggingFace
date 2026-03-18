
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. `protected` is only supported for Spaces.
    /// </summary>
    public enum RequestVisibility
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
    public static class RequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVisibility value)
        {
            return value switch
            {
                RequestVisibility.Private => "private",
                RequestVisibility.Public => "public",
                RequestVisibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => RequestVisibility.Private,
                "public" => RequestVisibility.Public,
                "protected" => RequestVisibility.Protected,
                _ => null,
            };
        }
    }
}