
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2GatedEnum6
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
    public static class ResponseItemVariant2GatedEnum6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2GatedEnum6 value)
        {
            return value switch
            {
                ResponseItemVariant2GatedEnum6.Auto => "auto",
                ResponseItemVariant2GatedEnum6.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2GatedEnum6? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseItemVariant2GatedEnum6.Auto,
                "manual" => ResponseItemVariant2GatedEnum6.Manual,
                _ => null,
            };
        }
    }
}