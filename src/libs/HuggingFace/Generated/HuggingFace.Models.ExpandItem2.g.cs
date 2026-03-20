
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpandItem2
    {
        /// <summary>
        /// 
        /// </summary>
        Formatted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpandItem2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpandItem2 value)
        {
            return value switch
            {
                ExpandItem2.Formatted => "formatted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpandItem2? ToEnum(string value)
        {
            return value switch
            {
                "formatted" => ExpandItem2.Formatted,
                _ => null,
            };
        }
    }
}