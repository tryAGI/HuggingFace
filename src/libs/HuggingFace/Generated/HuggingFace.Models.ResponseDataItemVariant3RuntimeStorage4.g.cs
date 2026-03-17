
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3RuntimeStorage4
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
    public static class ResponseDataItemVariant3RuntimeStorage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3RuntimeStorage4 value)
        {
            return value switch
            {
                ResponseDataItemVariant3RuntimeStorage4.Small => "small",
                ResponseDataItemVariant3RuntimeStorage4.Medium => "medium",
                ResponseDataItemVariant3RuntimeStorage4.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3RuntimeStorage4? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseDataItemVariant3RuntimeStorage4.Small,
                "medium" => ResponseDataItemVariant3RuntimeStorage4.Medium,
                "large" => ResponseDataItemVariant3RuntimeStorage4.Large,
                _ => null,
            };
        }
    }
}