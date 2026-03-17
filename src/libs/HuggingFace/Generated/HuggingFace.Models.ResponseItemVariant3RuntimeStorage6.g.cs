
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStorage6
    {
        /// <summary>
        /// 
        /// </summary>
        Small,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemVariant3RuntimeStorage6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStorage6 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStorage6.Small => "small",
                ResponseItemVariant3RuntimeStorage6.Medium => "medium",
                ResponseItemVariant3RuntimeStorage6.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStorage6? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseItemVariant3RuntimeStorage6.Small,
                "medium" => ResponseItemVariant3RuntimeStorage6.Medium,
                "large" => ResponseItemVariant3RuntimeStorage6.Large,
                _ => null,
            };
        }
    }
}