
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestGatedEnum6
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
    public static class RequestGatedEnum6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGatedEnum6 value)
        {
            return value switch
            {
                RequestGatedEnum6.Auto => "auto",
                RequestGatedEnum6.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGatedEnum6? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestGatedEnum6.Auto,
                "manual" => RequestGatedEnum6.Manual,
                _ => null,
            };
        }
    }
}