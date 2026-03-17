
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatedEnum2
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
    public static class RequestGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatedEnum2 value)
        {
            return value switch
            {
                RequestGatedEnum2.Auto => "auto",
                RequestGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestGatedEnum2.Auto,
                "manual" => RequestGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}