
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestFileEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Utf8,
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestFileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestFileEncoding value)
        {
            return value switch
            {
                RequestFileEncoding.Utf8 => "utf-8",
                RequestFileEncoding.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestFileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "utf-8" => RequestFileEncoding.Utf8,
                "base64" => RequestFileEncoding.Base64,
                _ => null,
            };
        }
    }
}