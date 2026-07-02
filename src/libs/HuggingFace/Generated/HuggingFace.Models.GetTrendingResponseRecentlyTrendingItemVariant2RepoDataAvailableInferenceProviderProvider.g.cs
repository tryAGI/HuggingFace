
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider
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
        Openai,
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Baseten => "baseten",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cerebras => "cerebras",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cohere => "cohere",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FalAi => "fal-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Groq => "groq",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.HfInference => "hf-inference",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Novita => "novita",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nscale => "nscale",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Openai => "openai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Publicai => "publicai",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Replicate => "replicate",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Scaleway => "scaleway",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Together => "together",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Baseten,
                "cerebras" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cerebras,
                "cohere" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cohere,
                "deepinfra" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FireworksAi,
                "groq" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Groq,
                "hf-inference" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.HfInference,
                "novita" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Novita,
                "nscale" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nscale,
                "openai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Openai,
                "ovhcloud" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Publicai,
                "replicate" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Replicate,
                "scaleway" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Scaleway,
                "together" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Together,
                "wavespeed" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}