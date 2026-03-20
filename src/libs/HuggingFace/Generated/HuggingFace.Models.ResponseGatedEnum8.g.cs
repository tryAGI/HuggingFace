
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedEnum8
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
    public static class ResponseGatedEnum8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedEnum8 value)
        {
            return value switch
            {
                ResponseGatedEnum8.Auto => "auto",
                ResponseGatedEnum8.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedEnum8? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseGatedEnum8.Auto,
                "manual" => ResponseGatedEnum8.Manual,
                _ => null,
            };
        }
    }
}