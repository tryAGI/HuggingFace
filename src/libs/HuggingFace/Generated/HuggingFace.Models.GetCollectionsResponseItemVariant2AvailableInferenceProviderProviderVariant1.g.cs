
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1
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
        HfInference,
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
        Openrouter,
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq => "groq",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita => "novita",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together => "together",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}