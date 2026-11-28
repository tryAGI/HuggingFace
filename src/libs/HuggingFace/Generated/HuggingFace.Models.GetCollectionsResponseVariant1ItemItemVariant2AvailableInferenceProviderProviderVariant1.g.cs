
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1
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
    public static class GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Groq => "groq",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Novita => "novita",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Together => "together",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}