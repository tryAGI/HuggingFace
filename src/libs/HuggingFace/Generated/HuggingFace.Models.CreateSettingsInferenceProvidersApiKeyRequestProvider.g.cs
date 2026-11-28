
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsInferenceProvidersApiKeyRequestProvider
    {
        /// <summary>
        ///
        /// </summary>
        FalAi,
        /// <summary>
        ///
        /// </summary>
        Replicate,
        /// <summary>
        ///
        /// </summary>
        Wavespeed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsInferenceProvidersApiKeyRequestProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsInferenceProvidersApiKeyRequestProvider value)
        {
            return value switch
            {
                CreateSettingsInferenceProvidersApiKeyRequestProvider.FalAi => "fal-ai",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Replicate => "replicate",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Wavespeed => "wavespeed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsInferenceProvidersApiKeyRequestProvider? ToEnum(string value)
        {
            return value switch
            {
                "fal-ai" => CreateSettingsInferenceProvidersApiKeyRequestProvider.FalAi,
                "replicate" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Replicate,
                "wavespeed" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Wavespeed,
                _ => null,
            };
        }
    }
}