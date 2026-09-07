
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateReposCreateRequestVariant1FileEncoding
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
    public static class CreateReposCreateRequestVariant1FileEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReposCreateRequestVariant1FileEncoding value)
        {
            return value switch
            {
                CreateReposCreateRequestVariant1FileEncoding.Base64 => "base64",
                CreateReposCreateRequestVariant1FileEncoding.Utf8 => "utf-8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReposCreateRequestVariant1FileEncoding? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateReposCreateRequestVariant1FileEncoding.Base64,
                "utf-8" => CreateReposCreateRequestVariant1FileEncoding.Utf8,
                _ => null,
            };
        }
    }
}