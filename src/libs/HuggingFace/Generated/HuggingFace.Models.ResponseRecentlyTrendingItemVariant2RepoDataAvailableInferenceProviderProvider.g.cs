
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabs,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Clarifai,
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
        Hyperbolic,
        /// <summary>
        /// 
        /// </summary>
        Nebius,
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
        Nvidia,
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
        Sambanova,
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
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Baseten => "baseten",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cerebras => "cerebras",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Clarifai => "clarifai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cohere => "cohere",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FalAi => "fal-ai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Groq => "groq",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.HfInference => "hf-inference",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nebius => "nebius",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Novita => "novita",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nscale => "nscale",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nvidia => "nvidia",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Openai => "openai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Publicai => "publicai",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Replicate => "replicate",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Sambanova => "sambanova",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Scaleway => "scaleway",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Together => "together",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cerebras,
                "clarifai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Clarifai,
                "cohere" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Cohere,
                "deepinfra" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.FireworksAi,
                "groq" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Groq,
                "hf-inference" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nebius,
                "novita" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Novita,
                "nscale" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nscale,
                "nvidia" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Nvidia,
                "openai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Openai,
                "ovhcloud" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Publicai,
                "replicate" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Replicate,
                "sambanova" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Sambanova,
                "scaleway" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Scaleway,
                "together" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Together,
                "wavespeed" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => ResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}