
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReposCreateRequestFileEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Utf8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReposCreateRequestFileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestFileEncoding value)
        {
            return value switch
            {
                CreateReposCreateRequestFileEncoding.Base64 => "base64",
                CreateReposCreateRequestFileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestFileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateReposCreateRequestFileEncoding.Base64,
                "utf-8" => CreateReposCreateRequestFileEncoding.Utf8,
                _ => null,
            };
        }
    }
}