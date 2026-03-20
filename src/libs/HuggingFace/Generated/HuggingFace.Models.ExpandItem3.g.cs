
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpandItem3
    {
        /// <summary>
        /// 
        /// </summary>
        Formatted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpandItem3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpandItem3 value)
        {
            return value switch
            {
                ExpandItem3.Formatted => "formatted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpandItem3? ToEnum(string value)
        {
            return value switch
            {
                "formatted" => ExpandItem3.Formatted,
                _ => null,
            };
        }
    }
}