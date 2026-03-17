
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpandItem
    {
        /// <summary>
        /// 
        /// </summary>
        Formatted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpandItem value)
        {
            return value switch
            {
                ExpandItem.Formatted => "formatted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "formatted" => ExpandItem.Formatted,
                _ => null,
            };
        }
    }
}