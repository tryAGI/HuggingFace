
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1GatedEnum6
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemVariant1GatedEnum6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1GatedEnum6 value)
        {
            return value switch
            {
                ResponseItemVariant1GatedEnum6.Auto => "auto",
                ResponseItemVariant1GatedEnum6.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1GatedEnum6? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseItemVariant1GatedEnum6.Auto,
                "manual" => ResponseItemVariant1GatedEnum6.Manual,
                _ => null,
            };
        }
    }
}