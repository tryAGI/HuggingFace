
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResolveType2
    {
        /// <summary>
        /// 
        /// </summary>
        ResolveCache,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolveType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolveType2 value)
        {
            return value switch
            {
                ResolveType2.ResolveCache => "resolve-cache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolveType2? ToEnum(string value)
        {
            return value switch
            {
                "resolve-cache" => ResolveType2.ResolveCache,
                _ => null,
            };
        }
    }
}