
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3RuntimeStorage2
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
    public static class ResponseItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                ResponseItemVariant3RuntimeStorage2.Small => "small",
                ResponseItemVariant3RuntimeStorage2.Medium => "medium",
                ResponseItemVariant3RuntimeStorage2.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseItemVariant3RuntimeStorage2.Small,
                "medium" => ResponseItemVariant3RuntimeStorage2.Medium,
                "large" => ResponseItemVariant3RuntimeStorage2.Large,
                _ => null,
            };
        }
    }
}