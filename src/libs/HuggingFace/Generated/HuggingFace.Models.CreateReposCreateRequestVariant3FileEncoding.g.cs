
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateReposCreateRequestVariant3FileEncoding
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
    public static class CreateReposCreateRequestVariant3FileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant3FileEncoding value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant3FileEncoding.Base64 => "base64",
                CreateReposCreateRequestVariant3FileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant3FileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateReposCreateRequestVariant3FileEncoding.Base64,
                "utf-8" => CreateReposCreateRequestVariant3FileEncoding.Utf8,
                _ => null,
            };
        }
    }
}