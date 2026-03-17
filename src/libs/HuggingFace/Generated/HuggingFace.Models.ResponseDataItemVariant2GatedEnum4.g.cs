
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant2GatedEnum4
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
    public static class ResponseDataItemVariant2GatedEnum4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant2GatedEnum4 value)
        {
            return value switch
            {
                ResponseDataItemVariant2GatedEnum4.Auto => "auto",
                ResponseDataItemVariant2GatedEnum4.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant2GatedEnum4? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseDataItemVariant2GatedEnum4.Auto,
                "manual" => ResponseDataItemVariant2GatedEnum4.Manual,
                _ => null,
            };
        }
    }
}