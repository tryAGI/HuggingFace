
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1 value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Baseten => "baseten",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Cerebras => "cerebras",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Cohere => "cohere",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Deepinfra => "deepinfra",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FalAi => "fal-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FeatherlessAi => "featherless-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FireworksAi => "fireworks-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Groq => "groq",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.HfInference => "hf-inference",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Novita => "novita",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Nscale => "nscale",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Openrouter => "openrouter",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Ovhcloud => "ovhcloud",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Publicai => "publicai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Replicate => "replicate",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Scaleway => "scaleway",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Together => "together",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Wavespeed => "wavespeed",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Baseten,
                "cerebras" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Cerebras,
                "cohere" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Cohere,
                "deepinfra" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Deepinfra,
                "fal-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FalAi,
                "featherless-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FeatherlessAi,
                "fireworks-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.FireworksAi,
                "groq" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Groq,
                "hf-inference" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.HfInference,
                "novita" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Novita,
                "nscale" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Nscale,
                "openrouter" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Openrouter,
                "ovhcloud" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Ovhcloud,
                "publicai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Publicai,
                "replicate" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Replicate,
                "scaleway" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Scaleway,
                "together" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Together,
                "wavespeed" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.Wavespeed,
                "zai-org" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderVariant1.ZaiOrg,
                _ => null,
            };
        }
    }
}