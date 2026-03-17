
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant1GatedEnum4
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
    public static class ResponseDataItemVariant1GatedEnum4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant1GatedEnum4 value)
        {
            return value switch
            {
                ResponseDataItemVariant1GatedEnum4.Auto => "auto",
                ResponseDataItemVariant1GatedEnum4.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant1GatedEnum4? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseDataItemVariant1GatedEnum4.Auto,
                "manual" => ResponseDataItemVariant1GatedEnum4.Manual,
                _ => null,
            };
        }
    }
}