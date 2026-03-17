
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant3RuntimeStorage2
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
    public static class ResponseVariant1ItemItemVariant3RuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant3RuntimeStorage2 value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant3RuntimeStorage2.Small => "small",
                ResponseVariant1ItemItemVariant3RuntimeStorage2.Medium => "medium",
                ResponseVariant1ItemItemVariant3RuntimeStorage2.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant3RuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseVariant1ItemItemVariant3RuntimeStorage2.Small,
                "medium" => ResponseVariant1ItemItemVariant3RuntimeStorage2.Medium,
                "large" => ResponseVariant1ItemItemVariant3RuntimeStorage2.Large,
                _ => null,
            };
        }
    }
}