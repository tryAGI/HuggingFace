
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStorage10
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
    public static class ResponseItemVariant3RuntimeStorage10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStorage10 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStorage10.Small => "small",
                ResponseItemVariant3RuntimeStorage10.Medium => "medium",
                ResponseItemVariant3RuntimeStorage10.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStorage10? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseItemVariant3RuntimeStorage10.Small,
                "medium" => ResponseItemVariant3RuntimeStorage10.Medium,
                "large" => ResponseItemVariant3RuntimeStorage10.Large,
                _ => null,
            };
        }
    }
}