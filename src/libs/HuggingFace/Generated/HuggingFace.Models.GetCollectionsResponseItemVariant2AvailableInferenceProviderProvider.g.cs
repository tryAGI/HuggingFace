
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider
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
    public static class GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Baseten => "baseten",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs => "black-forest-labs",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras => "cerebras",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Clarifai => "clarifai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cohere => "cohere",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra => "deepinfra",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FalAi => "fal-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi => "featherless-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi => "fireworks-ai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Groq => "groq",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.HfInference => "hf-inference",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic => "hyperbolic",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nebius => "nebius",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Novita => "novita",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nscale => "nscale",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nvidia => "nvidia",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Openai => "openai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud => "ovhcloud",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Publicai => "publicai",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Replicate => "replicate",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Sambanova => "sambanova",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway => "scaleway",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Together => "together",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed => "wavespeed",
                GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg => "zai-org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider? ToEnum(string value)
        {
            return value switch
            {
                "baseten" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Baseten,
                "black-forest-labs" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.BlackForestLabs,
                "cerebras" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cerebras,
                "clarifai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Clarifai,
                "cohere" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Cohere,
                "deepinfra" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Deepinfra,
                "fal-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FalAi,
                "featherless-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FeatherlessAi,
                "fireworks-ai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.FireworksAi,
                "groq" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Groq,
                "hf-inference" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.HfInference,
                "hyperbolic" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Hyperbolic,
                "nebius" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nebius,
                "novita" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Novita,
                "nscale" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nscale,
                "nvidia" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Nvidia,
                "openai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Openai,
                "ovhcloud" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Ovhcloud,
                "publicai" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Publicai,
                "replicate" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Replicate,
                "sambanova" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Sambanova,
                "scaleway" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Scaleway,
                "together" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Together,
                "wavespeed" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.Wavespeed,
                "zai-org" => GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider.ZaiOrg,
                _ => null,
            };
        }
    }
}