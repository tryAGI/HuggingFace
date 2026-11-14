
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersResponseItemCapabilitie
    {
        /// <summary>
        ///
        /// </summary>
        InferenceApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsTrustedPublishersResponseItemCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersResponseItemCapabilitie value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersResponseItemCapabilitie.InferenceApi => "inference-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "inference-api" => GetSettingsTrustedPublishersResponseItemCapabilitie.InferenceApi,
                _ => null,
            };
        }
    }
}