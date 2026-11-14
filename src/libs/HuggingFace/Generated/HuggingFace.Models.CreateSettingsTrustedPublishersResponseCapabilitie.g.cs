
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsTrustedPublishersResponseCapabilitie
    {
        /// <summary>
        ///
        /// </summary>
        InferenceApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsTrustedPublishersResponseCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsTrustedPublishersResponseCapabilitie value)
        {
            return value switch
            {
                CreateSettingsTrustedPublishersResponseCapabilitie.InferenceApi => "inference-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsTrustedPublishersResponseCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "inference-api" => CreateSettingsTrustedPublishersResponseCapabilitie.InferenceApi,
                _ => null,
            };
        }
    }
}