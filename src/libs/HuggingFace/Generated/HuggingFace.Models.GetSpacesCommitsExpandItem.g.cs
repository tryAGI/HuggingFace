
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesCommitsExpandItem
    {
        /// <summary>
        /// 
        /// </summary>
        Formatted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpacesCommitsExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesCommitsExpandItem value)
        {
            return value switch
            {
                GetSpacesCommitsExpandItem.Formatted => "formatted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesCommitsExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "formatted" => GetSpacesCommitsExpandItem.Formatted,
                _ => null,
            };
        }
    }
}