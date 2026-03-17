
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedEnum2
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
    public static class ResponseGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedEnum2 value)
        {
            return value switch
            {
                ResponseGatedEnum2.Auto => "auto",
                ResponseGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseGatedEnum2.Auto,
                "manual" => ResponseGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}