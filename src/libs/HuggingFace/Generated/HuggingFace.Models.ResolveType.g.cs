
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResolveType
    {
        /// <summary>
        /// 
        /// </summary>
        Resolve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolveType value)
        {
            return value switch
            {
                ResolveType.Resolve => "resolve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolveType? ToEnum(string value)
        {
            return value switch
            {
                "resolve" => ResolveType.Resolve,
                _ => null,
            };
        }
    }
}