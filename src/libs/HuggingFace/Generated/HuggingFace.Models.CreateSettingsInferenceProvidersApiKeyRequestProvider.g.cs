
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
        Baseten,
        /// <summary>
        ///
        /// </summary>
        Cerebras,
        /// <summary>
        ///
        /// </summary>
        Cohere,
        /// <summary>
        ///
        /// </summary>
        Deepinfra,
        /// <summary>
        ///
        /// </summary>
        FalAi,
        /// <summary>
        ///
        /// </summary>
        FeatherlessAi,
        /// <summary>
        ///
        /// </summary>
        FireworksAi,
        /// <summary>
        ///
        /// </summary>
        Groq,
        /// <summary>
        ///
        /// </summary>
        Novita,
        /// <summary>
        ///
        /// </summary>
        Nscale,
        /// <summary>
        ///
        /// </summary>
        Ovhcloud,
        /// <summary>
        ///
        /// </summary>
        Publicai,
        /// <summary>
        ///
        /// </summary>
        Replicate,
        /// <summary>
        ///
        /// </summary>
        Scaleway,
        /// <summary>
        ///
        /// </summary>
        Together,
        /// <summary>
        ///
        /// </summary>
        Wavespeed,
        /// <summary>
        ///
        /// </summary>
        ZaiOrg,
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
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Baseten => "baseten",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Cerebras => "cerebras",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Cohere => "cohere",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Deepinfra => "deepinfra",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.FalAi => "fal-ai",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.FeatherlessAi => "featherless-ai",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.FireworksAi => "fireworks-ai",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Groq => "groq",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Novita => "novita",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Nscale => "nscale",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Ovhcloud => "ovhcloud",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Publicai => "publicai",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Replicate => "replicate",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Scaleway => "scaleway",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Together => "together",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.Wavespeed => "wavespeed",
                CreateSettingsInferenceProvidersApiKeyRequestProvider.ZaiOrg => "zai-org",
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
                "baseten" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Baseten,
                "cerebras" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Cerebras,
                "cohere" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Cohere,
                "deepinfra" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Deepinfra,
                "fal-ai" => CreateSettingsInferenceProvidersApiKeyRequestProvider.FalAi,
                "featherless-ai" => CreateSettingsInferenceProvidersApiKeyRequestProvider.FeatherlessAi,
                "fireworks-ai" => CreateSettingsInferenceProvidersApiKeyRequestProvider.FireworksAi,
                "groq" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Groq,
                "novita" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Novita,
                "nscale" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Nscale,
                "ovhcloud" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Ovhcloud,
                "publicai" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Publicai,
                "replicate" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Replicate,
                "scaleway" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Scaleway,
                "together" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Together,
                "wavespeed" => CreateSettingsInferenceProvidersApiKeyRequestProvider.Wavespeed,
                "zai-org" => CreateSettingsInferenceProvidersApiKeyRequestProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}