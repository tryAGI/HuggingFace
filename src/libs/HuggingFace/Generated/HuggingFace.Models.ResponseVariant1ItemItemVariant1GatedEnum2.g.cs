
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant1GatedEnum2
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
    public static class ResponseVariant1ItemItemVariant1GatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant1GatedEnum2 value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant1GatedEnum2.Auto => "auto",
                ResponseVariant1ItemItemVariant1GatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant1GatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseVariant1ItemItemVariant1GatedEnum2.Auto,
                "manual" => ResponseVariant1ItemItemVariant1GatedEnum2.Manual,
                _ => null,
            };
        }
    }
}