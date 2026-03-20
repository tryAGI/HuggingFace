
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedEnum10
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
    public static class ResponseGatedEnum10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedEnum10 value)
        {
            return value switch
            {
                ResponseGatedEnum10.Auto => "auto",
                ResponseGatedEnum10.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedEnum10? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseGatedEnum10.Auto,
                "manual" => ResponseGatedEnum10.Manual,
                _ => null,
            };
        }
    }
}