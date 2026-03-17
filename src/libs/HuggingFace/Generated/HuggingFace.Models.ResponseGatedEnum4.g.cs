
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseGatedEnum4
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
    public static class ResponseGatedEnum4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseGatedEnum4 value)
        {
            return value switch
            {
                ResponseGatedEnum4.Auto => "auto",
                ResponseGatedEnum4.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseGatedEnum4? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseGatedEnum4.Auto,
                "manual" => ResponseGatedEnum4.Manual,
                _ => null,
            };
        }
    }
}