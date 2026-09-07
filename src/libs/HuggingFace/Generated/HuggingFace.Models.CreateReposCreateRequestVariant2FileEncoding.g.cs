
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateReposCreateRequestVariant2FileEncoding
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
    public static class CreateReposCreateRequestVariant2FileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant2FileEncoding value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant2FileEncoding.Base64 => "base64",
                CreateReposCreateRequestVariant2FileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant2FileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateReposCreateRequestVariant2FileEncoding.Base64,
                "utf-8" => CreateReposCreateRequestVariant2FileEncoding.Utf8,
                _ => null,
            };
        }
    }
}