
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedEnum6
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
    public static class ResponseGatedEnum6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedEnum6 value)
        {
            return value switch
            {
                ResponseGatedEnum6.Auto => "auto",
                ResponseGatedEnum6.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedEnum6? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseGatedEnum6.Auto,
                "manual" => ResponseGatedEnum6.Manual,
                _ => null,
            };
        }
    }
}