
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum EncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncodingFormat value)
        {
            return value switch
            {
                EncodingFormat.Float => "float",
                EncodingFormat.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "float" => EncodingFormat.Float,
                "base64" => EncodingFormat.Base64,
                _ => null,
            };
        }
    }
}