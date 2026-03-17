
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant1GatedEnum8
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
    public static class ResponseItemVariant1GatedEnum8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant1GatedEnum8 value)
        {
            return value switch
            {
                ResponseItemVariant1GatedEnum8.Auto => "auto",
                ResponseItemVariant1GatedEnum8.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant1GatedEnum8? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseItemVariant1GatedEnum8.Auto,
                "manual" => ResponseItemVariant1GatedEnum8.Manual,
                _ => null,
            };
        }
    }
}